using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03
{
    public partial class Editor : Form
    {
        Form1 fLogIn;
        public Editor()
        {
            InitializeComponent();
            fLogIn = new Form1();
            fLogIn.Show();
           
        }

        private void Editor_Load(object sender, EventArgs e)
        {
        
        }

        private void Editor_FormClosed(object sender, FormClosedEventArgs e)
        {
             
        }
        OpenFileDialog open = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rs = open.ShowDialog();
        }
    }
}
