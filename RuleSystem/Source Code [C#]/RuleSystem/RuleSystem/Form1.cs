using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Hi there, welcome to the Source Code of RuleSystem!
// first lets define some really cool stuff
//public String Rules = Application.StartupPath + "\\rules.txt";
namespace RuleSystem
{
    public partial class Form1 : Form
    {
        public String Rules = Application.StartupPath + "\\rules.txt";
        public Form1()
        {
            InitializeComponent();
           
            
            string content = File.ReadAllText(Rules);
            richTextBox1.Text = content;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
