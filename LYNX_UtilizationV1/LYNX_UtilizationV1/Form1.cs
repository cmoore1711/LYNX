using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LYNX_UtilizationV1
{
    public partial class Form1 : Form
    {
        List<String> utilPrompts = new List<string>();
        List<String> responses = new List<string>();


        MySqlConnection connection;
        string server = "DESKTOP-C42320E";
        string database = "diamond_turning";
        string currentTable = "utilization_704";
        string uid = "root";
        string password = "diamondturning";
        string connectionString;
        int clickCount = 0;
        int numPrompts = 0;
        string[] prompts = { "Form", "Finish", "Tool Lines", "Surface", "Metrics", "Etc" };



        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";



            foreach (string p in prompts)
            {
                utilPrompts.Add(p);
            }


            //utilPrompts.Add("Form");
            //utilPrompts.Add("Finish");
            //utilPrompts.Add("Tool lines");

            submitBtn.Visible = false;
            submitBtn.Enabled = false;
            numPrompts = utilPrompts.Count;
            qPromptLbl.Text = utilPrompts[clickCount];
        }
        private void excellentBtn_Click(object sender, EventArgs e)
        {
            responses.Add("1");
            buttonClicked();

        }
        private void avgBtn_Click(object sender, EventArgs e)
        {
            responses.Add("0");
            buttonClicked();
        }

        private void poorBtn_Click(object sender, EventArgs e)
        {
            responses.Add("-1");
            buttonClicked();
        }

        void buttonClicked()
        {
            clickCount++;
            if (clickCount < numPrompts)
            {
                qPromptLbl.Text = utilPrompts[clickCount];


            }
            if (clickCount == numPrompts)
            {
                qPromptLbl.Text = "Finished";
                submitBtn.Enabled = true;
                submitBtn.Visible = true;
            }

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            qPromptLbl.Text = utilPrompts[clickCount];
            startBtn.Enabled = false;
            startBtn.Visible = false;

        }

        void pushToMySQL()
        {

            string entryListString = "1,1,-1";
            string insertString = "INSERT INTO `diamond_turning`.`utilization_704`(`datetime`,`" +
                "Operator`,`Form`,`Finish`,`Tool Lines`,`Utilx`,`Utily`,`Utilz`,`StartStop`)" +
                " VALUES('NOW(),ColinTest," + entryListString + ",<{ Utilx: }>,<{ Utily: }>,<{ Utilz: }>,<{ StartStop: }>);";


            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = insertString;
                cmd.Prepare();

                // cmd.Parameters.AddWithValue("@Name", "Bill Gates");
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            //using (MySqlConnection con = new MySqlConnection(connectionString))
            //{
            //    con.Open();

            //    // Set up a command with the given query and associate
            //    // this with the current connection.
            //    using (MySqlCommand cmd = new MySqlCommand(insertString, con))
            //    {
            //        cmd.ExecuteNonQuery();

            //    }

            //}

        }

        private void startOverBtn_Click(object sender, EventArgs e)
        {
            clickCount = 0;
            responses.Clear();
            submitBtn.Enabled = false;
            submitBtn.Visible = false;
            qPromptLbl.Text = utilPrompts[clickCount];
            // pushToMySQL();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Submitted.");
        }

        private void testConnBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void previewSubBtn_Click(object sender, EventArgs e)
        {
            string previewTxt = "Your entries so far: " +Environment.NewLine+ Environment.NewLine;
            List<string> verboseResponse = new List<string>();

            foreach (string s in responses)
            {
                switch (int.Parse(s))
                {
                    case 1:
                        verboseResponse.Add("Good");
                        break;
                    case 0:
                        verboseResponse.Add("Average");
                        break;

                    case -1:
                        verboseResponse.Add("Bad");
                        break;

                }


            }

            int smaller = Math.Min(verboseResponse.Count(), prompts.Count());
            for (int i = 0; i < smaller; i++)
            {
                previewTxt += prompts[i] + ": " + verboseResponse[i] + Environment.NewLine+Environment.NewLine;
            }
            MessageBox.Show(previewTxt);
        }
        //INSERT INTO `diamond_turning`.`utilization_704`(`datetime`,`Operator`,`Form`,`Finish`,`Tool Lines`,`Utilx`,`Utily`,`Utilz`,`StartStop`)
        //VALUES(<{ datetime: }>,<{Operator: }>,<{Form: }>,<{Finish: }>,<{Tool Lines: }>,<{Utilx: }>,<{Utily: }>,<{Utilz: }>,<{StartStop: }>);
    }
}



