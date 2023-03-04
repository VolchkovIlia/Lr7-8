using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int counter = 0;
            double sum = 0;
            double summand = 0;
            double x;
            bool f=false;
            if(double.TryParse(txtPrecision.Text, out x)) 
            { 
                f= true;
            }
            do
            {
                counter++;
                if(double.TryParse(txtX.Text, out x) )
                {
                    summand=double.Parse(txtX.Text)/counter;
                }
                sum += summand;
            }while(f && Math.Abs(summand)>double.Parse(txtPrecision.Text));

            if (f)
            {
                lblResult.Text = "сумма" + sum + ",количество" + counter;
            }
            else
            {
                MessageBox.Show("Введите числовое значение!");
            }
        }
    }
}
