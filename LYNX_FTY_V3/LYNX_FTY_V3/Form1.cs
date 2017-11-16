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
    public partial class userLogin : Form
    {
        public userLogin()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString.Length + 1 <= globalVars.maxLenPIN)
                {
                    if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                    globalVars.currentNumpadString += "1";
                    pinTxtbox.Text += "1";
                }
            }
            catch { }
        }

        private void two_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString.Length + 1 <= globalVars.maxLenPIN)
                {
                    if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                    globalVars.currentNumpadString += "2";
                    pinTxtbox.Text += "2";
                }
            }
            catch { }
        }

        private void three_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString.Length + 1 <= globalVars.maxLenPIN)
                {
                    if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                    globalVars.currentNumpadString += "3";
                    pinTxtbox.Text += "3";
                }
            }
            catch { }
        }

        private void four_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString.Length + 1 <= globalVars.maxLenPIN)
                {
                    if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                    globalVars.currentNumpadString += "4";
                    pinTxtbox.Text += "4";
                }
            }
            catch { }
        }

        private void five_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString.Length + 1 <= globalVars.maxLenPIN)
                {
                    if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                    globalVars.currentNumpadString += "5";
                    pinTxtbox.Text += "5";
                }
            }
            catch { }
        }

        private void six_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString.Length + 1 <= globalVars.maxLenPIN)
                {
                    if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                    globalVars.currentNumpadString += "6";
                    pinTxtbox.Text += "6";
                }
            }
            catch { }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString.Length + 1 <= globalVars.maxLenPIN)
                {
                    if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                    globalVars.currentNumpadString += "7";
                    pinTxtbox.Text += "7";
                }
            }
            catch { }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString.Length + 1 <= globalVars.maxLenPIN)
                {
                    if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                    globalVars.currentNumpadString += "8";
                    pinTxtbox.Text += "8";
                }
            }
            catch { }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString.Length + 1 <= globalVars.maxLenPIN)
                {
                    if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                    globalVars.currentNumpadString += "9";
                    pinTxtbox.Text += "9";
                }
            }
            catch { }
        }
        private void zero_Click(object sender, EventArgs e)
        {
            try
            {
                if (globalVars.currentNumpadString.Length + 1 <= globalVars.maxLenPIN)
                {
                    if (globalVars.currentNumpadString == " ") { globalVars.currentNumpadString = ""; }
                    globalVars.currentNumpadString += "0";
                    pinTxtbox.Text += "0";
                }
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
                        pinTxtbox.Text = "";
                        break;
                    default:
                        globalVars.currentNumpadString = globalVars.currentNumpadString.Substring(0, globalVars.currentNumpadString.Length - 1);

                        try
                        {
                            pinTxtbox.Text = pinTxtbox.Text.Substring(0, pinTxtbox.Text.Length - 1);
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
                pinTxtbox.Text = "";
            }
            catch { }
        }

        //End numpad

        private void continueBtn_Click(object sender, EventArgs e)
        {
            globalVars.currentUser = pinTxtbox.Text;
            globalVars.currentUserPIN = pinTxtbox.Text;
            globalVars.currentNumpadString = "";
            this.Hide();
            FTY1 fMain = new FTY1();
            fMain.Location = new Point(0, 0);
            fMain.Show();

        }

        private void userLogin_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }
    }
}
