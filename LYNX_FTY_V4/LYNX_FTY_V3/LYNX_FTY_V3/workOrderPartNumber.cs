using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LYNX_FTY_V3
{
    public partial class workOrderPartNumber : Form
    {
        public workOrderPartNumber()
        {
            InitializeComponent();
        }

        bool partNum = false;
        bool workOrder = false;
      
        private void workOrderPartNumber_Load(object sender, EventArgs e)
        {
            inputTxtbox.Text = globalVars.workOrder;
            this.Location = new Point(0, 0);
            this.TopMost = true;

        }

        private void one_Click(object sender, EventArgs e)
        {
            try
            { 
                    if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                    globalVars.currentNumpadString += "1";
                    inputTxtbox.Text += "1";               
            }
            catch { }
        }

        private void two_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                globalVars.currentNumpadString += "2";
                inputTxtbox.Text += "2";
            }
            catch { }
        }

        private void three_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                globalVars.currentNumpadString += "3";
                inputTxtbox.Text += "3";
            }
            catch { }
        }

        private void four_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                globalVars.currentNumpadString += "4";
                inputTxtbox.Text += "4";
            }
            catch { }
        }

        private void five_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                globalVars.currentNumpadString += "5";
                inputTxtbox.Text += "5";
            }
            catch { }
        }

        private void six_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                globalVars.currentNumpadString += "6";
                inputTxtbox.Text += "6";
            }
            catch { }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                globalVars.currentNumpadString += "7";
                inputTxtbox.Text += "7";
            }
            catch { }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                globalVars.currentNumpadString += "8";
                inputTxtbox.Text += "8";
            }
            catch { }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                globalVars.currentNumpadString += "9";
                inputTxtbox.Text += "9";
            }
            catch { }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                globalVars.currentNumpadString += "0";
                inputTxtbox.Text += "0";
            }
            catch { }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            try
            {
                switch (globalVars.currentNumpadString.Length)
                {
                    case 0:
                        break;
                    case 1:
                        globalVars.currentNumpadString = "";
                        inputTxtbox.Text = "";
                        break;
                    default:
                        globalVars.currentNumpadString = globalVars.currentNumpadString.Substring(0, globalVars.currentNumpadString.Length - 1);

                        try
                        {
                            inputTxtbox.Text = inputTxtbox.Text.Substring(0, inputTxtbox.Text.Length - 1);
                        }
                        catch { }
                        break;

                }
            }
            catch { }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            try
            {
                globalVars.currentNumpadString = "";
                inputTxtbox.Text = "";
            }
            catch { }
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                globalVars.currentNumpadString = "";
                inputTxtbox.Text = "";
                partNum = false;
                workOrder = false;
            }
            catch { }
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
           if(workOrder == false)
            {
                workOrder = true;
                globalVars.workOrder = inputTxtbox.Text;
             
                globalVars.currentNumpadString ="";
                inputTxtbox.Text = globalVars.partNumber;
                txtLbl.Text = "Please enter the Part Number:";
            }
            else if (partNum ==false)
            {
                
                partNum = true;
           
                globalVars.partNumber = inputTxtbox.Text;
                
                globalVars.currentNumpadString = "";
                this.Close();
            }
           
           
        }
    }
}
