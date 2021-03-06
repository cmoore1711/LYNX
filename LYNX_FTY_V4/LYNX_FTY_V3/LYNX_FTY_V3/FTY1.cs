﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Threading;

namespace LYNX_FTY_V3
{
    public partial class FTY1 : Form
    {
        public FTY1()
        {
            InitializeComponent();
        }

        DateTime currentTime;
        DateTime startTime;


        private void FTY1_Load(object sender, EventArgs e)
        {
            userTxt.Text = "User: " + globalVars.currentUser;
            orderTxt.Text = "Order Number: " + globalVars.workOrder;
            partNumberTxt.Text = "Part Number: " + globalVars.partNumber;
            startTimeTxt.Text = "Start Time: " + DateTime.Now.ToString("h:mm:ss tt");
            machineNameTxt.Text = "Machine: " + "N704";
            databaseTxt.Text = "Database: " + "n704";
            tableTxt.Text = "Table: " + "FTY";
            currentTimeTimer.Interval = 500;
            currentTimeTimer.Start();
            workOpartNTimer.Interval = 100;
            workOpartNTimer.Start();
            partNumberBtn.PerformClick();
            startTime = DateTime.Now;
            this.Location = new Point(0, 0);
        }
        private void currentTimeTimer_Tick(object sender, EventArgs e)
        {
            currentTimeTxt.Text = "Current Time: " + DateTime.Now.ToString("h:mm:ss tt");
            currentTime = DateTime.Now;
            try
            {
                TimeSpan diff = currentTime.Subtract(startTime);

                string res = String.Format("{0}:{1}:{2}", diff.Hours, diff.Minutes, diff.Seconds);

                elapsedTimeTxt.Text = "Elapsed Time(h:m:s): " + res;


            }
            catch { }
    
        }
        private void orderTxt_Click(object sender, EventArgs e)
        {
         
        }
        //Good Btn
        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            entriesListbox.Items.Add(DateTime.Now.ToString("MM/dd/yyyy, hh:mm:ss:fff") + ", GOOD");

        }

        //Bad Btn
        private void badBtn_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            string[] reasonsForbadPart;
            string reasonsForbadPartString = "";
            using (Reasons r = new Reasons())
            {
                // init Reasons form
                var result = r.ShowDialog();
                r.Location = new Point(0, 0);
                //try
                //{
                if (result == DialogResult.Cancel)
                {
                    reasonsForbadPart = r.ReasonString;
                    reasonsForbadPartString = String.Join(", ", reasonsForbadPart);

                }

                //}
                //catch { }

                entriesListbox.Items.Add(DateTime.Now.ToString("MM/dd/yyyy, hh:mm:ss:fff") + ", BAD, Reason(s): " + reasonsForbadPartString);


            }



            //string reason = Microsoft.VisualBasic.Interaction.InputBox("Reason for bad part: ", "Reason", "", 0, 0);
            //^^Not working with mono


        }




        private void partNumberBtn_Click(object sender, EventArgs e)
        {
            workOrderPartNumber wopn = new workOrderPartNumber();
            wopn.Show();
            wopn.Location = new Point(0, 0);
        }

        private void workOpartNTimer_Tick(object sender, EventArgs e)
        {
            partNumberTxt.Text ="Part Number: "+ globalVars.partNumber;
            orderTxt.Text = "Work Order Number: " + globalVars.workOrder;
        }

        private void FTY1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(commitOnCloseChk.Checked == true)
            {
                commitData();
            }
            Application.Exit();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void scrollUpBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                entriesListbox.SelectedIndex = entriesListbox.SelectedIndex - 1;             
            }
            catch { }
        }

        private void scrollDownBtn_Click(object sender, EventArgs e)
        {
            try
            {
                entriesListbox.SelectedIndex = entriesListbox.SelectedIndex + 1;
            }
            catch { }
        }

        private void switchUserBtn_Click(object sender, EventArgs e)
        {
            userLogin login = new userLogin();
            this.Hide();
            login.Show();
            login.Location = new Point(0, 0);
        }

        private void undoEntryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                entriesListbox.Items.RemoveAt(entriesListbox.Items.Count - 1);
            }
            catch { }
        }

        private void commitBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string connectionString = "Server=10.0.0.224;Database=test;Uid=admin;Pwd=diamondturning;";
                string[] entriesString = entriesListbox.Items.OfType<string>().ToArray();




                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand cmd;
                connection.Open();
                try
                {
                    for (int i = 0; i< entriesString.Length; i++) {
                        cmd = connection.CreateCommand();
                        Console.WriteLine("insert into test1(datetime,instring)values(NOW(),\"" + entriesString[i].ToString() + "\");");
                        cmd.CommandText = "insert into test1(datetime,instring)values(NOW(),\"" + entriesString[i].ToString()+"\");";
                    cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }

                //COMMIT contents of entries listbox TO SQL HERE!

                commitData();

            }
            catch {
                MessageBox.Show("Failed");
            }

        }



        private void commitData()
        {
            entriesListbox.Items.Clear();
            MessageBox.Show("Committed to Database successfully");
            lastCommitLbl.Text = DateTime.Now.ToString("h:mm:ss:fff tt");
        }

        private void FTY1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
