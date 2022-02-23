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
        private enum eOperation
        {
            e_None,
            e_Add,
            e_Sub,
            e_Div,
            e_Mul,
            e_Pri
        }

        public Form1()
        {
            InitializeComponent();
        }

        private static eOperation m_previousOperation = eOperation.e_None;

        private void PerformCalculation(eOperation operationToPerfom)
        {
            List<double> inputtedNumbers = new List<double>();
            switch (operationToPerfom)
            {
                case eOperation.e_None:
                    break;
                case eOperation.e_Add:
                    inputtedNumbers = textDisplay.Text.Split(" + ").Select(double.Parse).ToList();
                    textDisplay.Text = (inputtedNumbers[0] + inputtedNumbers[1]).ToString();
                    break;
                case eOperation.e_Sub:
                    inputtedNumbers = textDisplay.Text.Split(" - ").Select(double.Parse).ToList();
                    textDisplay.Text = (inputtedNumbers[0] - inputtedNumbers[1]).ToString();
                    break;
                case eOperation.e_Div:
                    try
                    {
                        inputtedNumbers = textDisplay.Text.Split(" ÷ ").Select(double.Parse).ToList();
                        if(inputtedNumbers[1] == (double)0)
                        {
                            throw new DivideByZeroException(); // because apparently it is infinity otherwise... Weird C#
                        }
                        textDisplay.Text = (inputtedNumbers[0] / inputtedNumbers[1]).ToString();
                    }
                    catch(DivideByZeroException)
                    {
                        textDisplay.Text = "ERROR: CAN'T DIVIDE BY ZERO";
                    }
                    break;
                case eOperation.e_Mul:
                    inputtedNumbers = textDisplay.Text.Split(" x ").Select(double.Parse).ToList();
                    textDisplay.Text = (inputtedNumbers[0] * inputtedNumbers[1]).ToString();
                    break;
                case eOperation.e_Pri:
                    break;
                default:
                    break;
            }
            m_previousOperation = eOperation.e_None;
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
            m_previousOperation = eOperation.e_None;
            textDisplay.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            m_previousOperation = eOperation.e_None;
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1, 1);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (m_previousOperation != eOperation.e_None)
            {
                PerformCalculation(m_previousOperation);
            }

            m_previousOperation = eOperation.e_Div;
            textDisplay.Text += " ÷ ";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (m_previousOperation != eOperation.e_None)
            {
                PerformCalculation(m_previousOperation);
            }

            m_previousOperation = eOperation.e_Mul;
            textDisplay.Text += " x ";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (m_previousOperation != eOperation.e_None)
            {
                PerformCalculation(m_previousOperation);
            }

            m_previousOperation = eOperation.e_Sub;
            textDisplay.Text += " - ";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (m_previousOperation != eOperation.e_None)
            {
                PerformCalculation(m_previousOperation);
            }

            m_previousOperation = eOperation.e_Add;
            textDisplay.Text += " + ";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if(m_previousOperation != eOperation.e_None)
            {
                PerformCalculation(m_previousOperation);
            }
        }

        private void btnPrime_Click(object sender, EventArgs e)
        {
            m_previousOperation = eOperation.e_Pri;
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
