using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Week10HW
{

    public partial class Form1 : Form
    {
        public void SwitchTab(TabControl tabControl, string tabPageName)
        {
            // Find TabPage
            TabPage selectedTab = tabControl.TabPages[tabPageName];

            if (selectedTab == null)
                throw new Exception("No TabPage found with the specified name");

            // Loop through all TabPages
            foreach (TabPage tab in tabControl.TabPages)
            {
                if (tab == selectedTab)
                {
                    // Make this TabPage Visible
                    tab.Visible = true;
                    tabControl.SelectedTab = tab;
                }
                else
                {
                    // Hide other TabPages
                    tab.Visible = false;
                }
            }
        }

        string name = "";
        string phoneNumber = "";
        string gender = "";

        string commitedCrimes = "";
        string theKittyOrDoggy = "";
        string gotMilk = "";
        string whatTimeIsItText = "";
        string choiceExplaination = "";
        string waswas = "";
        string gullible = ""; 

        public Form1()
        {
            InitializeComponent();
            SwitchTab(tabControl1, "introPage");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SwitchTab(tabControl1, "baseUserInfoPage");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void baseUserInfoPage_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maleButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox objTextBox = (System.Windows.Forms.TextBox)sender;
            phoneNumber = objTextBox.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void thridQuestionSet_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            waswas = "yes";
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            gullible = "yes!";
        }

        private void exitSurvey_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (commitedCrimes != "")
            {

                if (commitedCrimes == "yes")
                {
                    SwitchTab(tabControl1, "secondQuestionSet");
                } else
                {
                    nextPage1.Text = "Wrong, you definetly lied, choose the right answer.";
                    nextPage1.Location = new Point(208, 304);
                }

                
            }
            else
            {
                nextPage1.BackColor = Color.Red;
            }
            
        }

        private void nextPage5_Click(object sender, EventArgs e)
        {
            if (waswas != "" && gullible != "")
            {
                SwitchTab(tabControl1, "endPage");
            }
            else
            {
                nextPage5.BackColor = Color.Red;
            }
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            if (name != "" && gender != "" && phoneNumber != "")
            {
                SwitchTab(tabControl1, "firstQuestionSet");
            } else
            {
                nextPage.BackColor = Color.Red;
            }
            
        }

        private void nextPage2_Click(object sender, EventArgs e)
        {
            if (theKittyOrDoggy != "")
            {
                SwitchTab(tabControl1, "thirdQuestionSet");
            }
            else
            {
                nextPage2.BackColor = Color.Red;
            }
            
        }

        private void nextPage3_Click(object sender, EventArgs e)
        {
            if (gotMilk != "" && whatTimeIsItText != "")
            {

                if (theKittyOrDoggy == "kitty")
                {
                    label16.Text = "Unbelievable. I cant believe you picked\nthe kitty back there. Explain yourself.";
                }
                else
                {
                    label16.Text = "Unbelievable. I cant believe you picked\nthe doggy back there. Explain yourself.";
                }

                SwitchTab(tabControl1, "fourthQuestionSet");
            }
            else
            {
                nextPage3.BackColor = Color.Red;
            }
        }

        private void nextPage4_Click(object sender, EventArgs e)
        {
            if (choiceExplaination != "")
            {
                SwitchTab(tabControl1, "fifthQuestionSet");
            }
            else
            {
                nextPage4.BackColor = Color.Red;
            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox objTextBox = (System.Windows.Forms.TextBox)sender;
            name = objTextBox.Text;
        }

        private void femaleButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void crimeYes_CheckedChanged(object sender, EventArgs e)
        {
            commitedCrimes = "yes";

            nextPage1.Location = new Point(396, 304);
            nextPage1.Text = "Next Page";
        }

        private void crimeNo_CheckedChanged(object sender, EventArgs e)
        {
            commitedCrimes = "no";
        }

        private void theKitty_CheckedChanged(object sender, EventArgs e)
        {
            theKittyOrDoggy = "kitty";
        }

        private void theDoggy_CheckedChanged(object sender, EventArgs e)
        {
            theKittyOrDoggy = "doggy";
        }

        private void haveMilk_CheckedChanged(object sender, EventArgs e)
        {
            gotMilk = "yes";
        }

        private void outtaMilk_CheckedChanged(object sender, EventArgs e)
        {
            gotMilk = "no";
        }

        private void whatTimeIsIt_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox objTextBox = (System.Windows.Forms.TextBox)sender;
            whatTimeIsItText = objTextBox.Text;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            
            
        }

        private void kittyDoggyText_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox objTextBox = (System.Windows.Forms.TextBox)sender;
            choiceExplaination = objTextBox.Text;
        }

        private void wasWasNo_CheckedChanged(object sender, EventArgs e)
        {
            waswas = "no";
        }
    }
}
