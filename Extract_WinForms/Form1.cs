using System;
using System.Windows.Forms;

using Namespace1;

namespace Extract_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new UseInForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UseInForm();
        }
    }
}