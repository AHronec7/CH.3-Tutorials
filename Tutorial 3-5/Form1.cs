using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_3_5
{
    public partial class Form1 : Form
    { 

        // declare the constant fields

            const decimal fivecents = 0.05m;
            const decimal tencents = 0.10m;
            const decimal twentyfivecents = 0.25m;
            const decimal fiftycents = 0.50m;

        // field variable to hold the total
            private decimal total = 0m;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FiveCentsPictureBox_Click(object sender, EventArgs e)
        {

            // add the value of 5 cents to the total

            total += fivecents;

            // display the total, formatted as currency

            TotalTextBox.Text = total.ToString("c");
        }

        private void TenCentsPictureBox_Click(object sender, EventArgs e)

        {
            // add the value of ten cents to the total
            total += tencents;

            TotalTextBox.Text = total.ToString("c");
        }

        private void TwentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            // add value of twenty five cents to the total

            total += twentyfivecents;

            TotalTextBox.Text = total.ToString("c");

        }

        private void FiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            // add the value of fifty cents to the total

            total += fiftycents;

            TotalTextBox.Text = total.ToString("c");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
