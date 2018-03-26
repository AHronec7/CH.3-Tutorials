using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter3_Tutorial
{
    public partial class Tutorial3_1 : Form
    {
        public Tutorial3_1()
        {
            InitializeComponent();
        }





        private void ShowDateButton_Click(object sender, EventArgs e)
        {

            try
            {
                string output;

                output = DayOfWeekBox.Text + "," +
                NameOfMonthBox.Text + " " +
                DayOfMonthBox.Text + "," +
                YearBox.Text;

                //display output in DateLabel

                DateOutput.Text = output;


            }

            catch
            {
                MessageBox.Show("error");
            }
        }




            private void ClearButton_Click(object sender, EventArgs e)

            
            {


            try
            {

            
                // clear the text boxes
                DayOfWeekBox.Text = "";
                NameOfMonthBox.Text = "";
                DayOfMonthBox.Text = "";
                YearBox.Text = "";

                DateOutput.Text = "";



            }


            catch
            {
                MessageBox.Show("error");
            }
       
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // now close,exit the form

            this.Close();
        }
    }
}
