using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_2
{
    public partial class FuelForm : Form
    {
        public FuelForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {



            try
            {

                double miles;
                double gallons;
                double mpg;

                // get the miles driven and assign it to the miles variable

                miles = double.Parse(MilesTextBox.Text);

                // get the gallons use and assign it to the gallons variable

                gallons = double.Parse(GasTextBox.Text);

                // calculate the MPG

                mpg = miles / gallons;

                MPGBox.Text = mpg.ToString();


            }

            catch
            {
                MessageBox.Show("error");
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
