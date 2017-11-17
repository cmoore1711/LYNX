using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


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
            entriesListbox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + ", GOOD");

        }

        //Bad Btn
        private void badBtn_Click(object sender, EventArgs e)
        {
            //string reason = Microsoft.VisualBasic.Interaction.InputBox("Reason for bad part: ", "Reason", "", 0, 0);
            //^^Not working with mono

            entriesListbox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + ", BAD, Reason: " + "#15"+" (Scratch/ Digs)");

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
    }
}
