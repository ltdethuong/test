using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace _01
{
   
    public partial class Form1 : Form
    {
        private int number;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text != null)
            {
                timer1.Interval = Convert.ToInt32(textBox1.Text) * 1000;
                timer1.Enabled = true;
                if (radioButton1.Checked)
                {
                    Process.Start("shutdown", "/s");
                }
                else if (radioButton2.Checked)
                {
                    Process.Start("shutdown", "/r");
                }
                else if (radioButton3.Checked)
                {
                    Process.Start("shutdown", "/l");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&& !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
