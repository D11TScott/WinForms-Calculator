using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                Clipboard.SetText(textDisplay.Text);
            }
            else
            {
                Clipboard.SetText("");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1, 1);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            textDisplay.Text += " ÷ ";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            textDisplay.Text += " x ";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            textDisplay.Text += " - ";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textDisplay.Text += " + ";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            textDisplay.Text += " = ";
        }

        private void btnPrime_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "9";
        }
    }
}
