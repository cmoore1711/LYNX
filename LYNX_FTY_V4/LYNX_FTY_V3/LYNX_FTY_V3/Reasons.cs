using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LYNX_FTY_V3
{
    public partial class Reasons : Form
    {
        public Reasons()
        {
            InitializeComponent();
        }
      

        private void Reasons_Load(object sender, EventArgs e)
        {
         

        }

        private void one_Click(object sender, EventArgs e)
        {
            try
            {          
                reasonTxtbox.Text += "1";
            }
            catch { }
        }

        private void two_Click(object sender, EventArgs e)
        {
            try
            {
                reasonTxtbox.Text += "2";
            }
            catch { }
        }

        private void three_Click(object sender, EventArgs e)
        {
            try
            {
                reasonTxtbox.Text += "3";
            }
            catch { }
        }

        private void four_Click(object sender, EventArgs e)
        {
            try
            {
                reasonTxtbox.Text += "4";
            }
            catch { }
        }

        private void five_Click(object sender, EventArgs e)
        {
            try
            {
                reasonTxtbox.Text += "5";
            }
            catch { }
        }

        private void six_Click(object sender, EventArgs e)
        {
            try
            {
                reasonTxtbox.Text += "6";
            }
            catch { }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            try
            {
                reasonTxtbox.Text += "7";
            }
            catch { }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            try
            {
                reasonTxtbox.Text += "8";
            }
            catch { }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            try
            {
                reasonTxtbox.Text += "9";
            }
            catch { }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            try
            {
                reasonTxtbox.Text += "0";
            }
            catch { }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            try
            {
                reasonTxtbox.Text = reasonTxtbox.Text.Substring(0, reasonTxtbox.Text.Length - 1);
            }
            catch { }
           
        }

        private void clear_Click(object sender, EventArgs e)
        {
            try
            {
                reasonTxtbox.Text = "";
            }
            catch { }
           
        }

        private void reasonTxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(reasonTxtbox.Text,out int result))
                {
                    if (int.Parse(reasonTxtbox.Text) > 0 && int.Parse(reasonTxtbox.Text) < 32) 
                    {
                        try
                        {

                            definitioncurrlbl.Text = globalVars.possibleReasons[int.Parse(reasonTxtbox.Text) + 1];
                        }
                        catch { }
                    }
                    else
                    {
                        definitioncurrlbl.Text = "Invalid reason number";
                    }

                }
                else
                {
                    reasonTxtbox.Text = "";
                    definitioncurrlbl.Text = "";
                }


            }
            catch {
                reasonTxtbox.Text = "";

            }
        }

        public string[] ReasonString
        {    
        get { return reasonsListbox.Items.OfType<string>().ToArray(); }   
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                reasonsListbox.Items.Add(reasonTxtbox.Text + "-> " + globalVars.possibleReasons[int.Parse(reasonTxtbox.Text)+1]);

                reasonTxtbox.Clear();
            }
            catch {
                reasonsListbox.Items.Add("");
                reasonTxtbox.Clear();
            }

            this.Close();
        }

        private void addReasonBtn_Click(object sender, EventArgs e)
        {
            try
            {
                reasonsListbox.Items.Add(reasonTxtbox.Text + "-> " + globalVars.possibleReasons[int.Parse(reasonTxtbox.Text) + 1]);

                reasonTxtbox.Clear();
            }
            catch
            {
                reasonsListbox.Items.Add("");
                reasonTxtbox.Clear();
            }
            }

        private void startOverBtn_Click(object sender, EventArgs e)
        {
            try
            {
                reasonTxtbox.Text = "";
                reasonsListbox.Items.Clear();
            }
            catch { }
        }

        private void definitionsHelpBtn_Click(object sender, EventArgs e)
        {
            string allReasons = "Reasons for Rejection" +"\n\n";

            for (int i = 0; i< globalVars.possibleReasons.Count; i++)
            {
                allReasons = allReasons + (i+1).ToString() + ". " + globalVars.possibleReasons[i].ToString() + "\n";   
            }
            MessageBox.Show(allReasons);
         
        }
    }
}
