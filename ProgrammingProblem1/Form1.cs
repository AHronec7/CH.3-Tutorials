using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProblem1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname;
            string middlename;
            string lastname;
            string title;

            firstname = textBox1.Text;
            middlename = textBox2.Text;
            lastname = textBox3.Text;
            title = textBox4.Text;


            listBox1 = (title + "" + firstname + "" + lastname);


        }
    }
}
