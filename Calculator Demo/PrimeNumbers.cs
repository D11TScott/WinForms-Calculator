using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator_Demo
{
    public partial class PrimeNumberDialogueWindow : Form
    {
        public PrimeNumberDialogueWindow(double inputtedNumber)
        {
            InitializeComponent();

            textDisplay.Text = inputtedNumber % 1 == 0 && IsPrime((int)inputtedNumber)
                ? inputtedNumber.ToString() + " is a prime number!"
                : inputtedNumber.ToString() + " is not a prime number!";
        }

        private bool IsPrime(int number)
        {
            for(int i = 2; i <= number / 2; ++i)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
