using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AverageButton_Click(object sender, EventArgs e)
        {
            try
            {
                double test1;
                double test2;
                double test3;
                double average;

                //get the three test scores

                test1 = double.Parse(Test1Box.Text);
                test2 = double.Parse(Test2Box.Text);
                test3 = double.Parse(Test3Box.Text);

                //calculate the AVG test score

                average = (test1 + test2 + test3) / 3.0;

                //display the AVG score with it rounded to the first decimal point


                AvgTestBox.Text = average.ToString("n1");

            }

            catch (Exception ex)
            {

                // display error message

                MessageBox.Show(ex.Message);
            }
        
        

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // clear the input and ouput controls

            Test1Box.Text = "";
            Test2Box.Text = "";
            Test3Box.Text = "";
            AvgTestBox.Text = "";
               
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //close form

            this.Close();
        }
    }

}