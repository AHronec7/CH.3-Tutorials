using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


                decimal originalprice;
                decimal discount;
                decimal discounttotal;
                decimal saleprice;

                //get the items original price

                originalprice = decimal.Parse(OriginalPriceBox.Text);


                // get the discount percentage
                discount = decimal.Parse(DiscountPriceBox.Text);

                // move decimal 2 places...

                discount = discount / 100;

                //calculate amount

                discounttotal = originalprice * discount;

                //calculate sale price

                saleprice = originalprice - discounttotal;

                //display sale price

                SalePriceBox.Text = saleprice.ToString("c");







            

       

            private void ExitButton_Click(object sender, EventArgs e)
            {
                this.Close();
            }

         
        }
    }

