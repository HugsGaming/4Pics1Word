using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Pics1Word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddLetter(object sender, EventArgs e)
        {
            for(int i = 1; i <= 7; i++)
            {
                string butNum = "answer" + i;
                if(this.Controls[butNum].Text == string.Empty)
                {
                    this.Controls[butNum].Text = ((Button)sender).Text;
                    ((Button)sender).Enabled = false;
                    this.Controls[butNum].Enabled = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if(answer7.Text != string.Empty)
            {
                string answer = "CONSOLE";
                string givenAnswer = string.Empty;
                for(int i = 1; i <= 7; i++)
                {
                    string butNum = "answer" + i;
                    givenAnswer += this.Controls[butNum].Text;
                }
                if(givenAnswer == answer)
                {
                    MessageBox.Show(givenAnswer + " is the word. You win.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(givenAnswer + " is not the word. Try again.");
                }
            }
        }
        private void ReturnLetter(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
            {
                string butNum = "letter" + i;
                if(((Button)sender).Text == this.Controls[butNum].Text && this.Controls[butNum].Enabled == false)
                {
                    ((Button)sender).Text = string.Empty;
                    this.Controls[butNum].Enabled = true;
                    ((Button)sender).Enabled = false;
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}