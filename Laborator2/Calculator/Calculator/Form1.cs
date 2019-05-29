using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string firstNumber;
        string secondNumber;
        bool firstOrSecondNumber = true;
        string operation;
        double result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if(CalculResultTb.Text == "0")
            {
                CalculResultTb.Clear();
            }
            CalculResultTb.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (CalculResultTb.Text == "0")
            {
                CalculResultTb.Clear();
            }
            CalculResultTb.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (CalculResultTb.Text == "0")
            {
                CalculResultTb.Clear();
            }
            CalculResultTb.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (CalculResultTb.Text == "0")
            {
                CalculResultTb.Clear();
            }
            CalculResultTb.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (CalculResultTb.Text == "0")
            {
                CalculResultTb.Clear();
            }
            CalculResultTb.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (CalculResultTb.Text == "0")
            {
                CalculResultTb.Clear();
            }
            CalculResultTb.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (CalculResultTb.Text == "0")
            {
                CalculResultTb.Clear();
            }
            CalculResultTb.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (CalculResultTb.Text == "0")
            {
                CalculResultTb.Clear();
            }
            CalculResultTb.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (CalculResultTb.Text == "0")
            {
                CalculResultTb.Clear();
            }
            CalculResultTb.Text += "9";
        }

        private void PowBtn_Click(object sender, EventArgs e)
        {
            if (operation != null)
            {
            }
            else
            {
                if (CalculResultTb.Text != "")
                {
                    operation = "^";
                    firstNumber = CalculResultTb.Text;
                    HistoryRtb.Text += firstNumber + operation;
                    firstOrSecondNumber = false;
                    CalculResultTb.Text = "0";
                }
            }
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            if (operation != null)
            {
            }
            else
            {
                if (CalculResultTb.Text != "")
                {
                    operation = "/";
                    firstNumber = CalculResultTb.Text;
                    HistoryRtb.Text += firstNumber + operation;
                    firstOrSecondNumber = false;
                    CalculResultTb.Text = "0";
                }
            }
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            if (operation != null)
            {
            }
            else
            {
                if (CalculResultTb.Text != "")
                {
                    operation = "*";
                    firstNumber = CalculResultTb.Text;
                    HistoryRtb.Text += firstNumber + operation;
                    firstOrSecondNumber = false;
                    CalculResultTb.Text = "0";
                }
            }
        }

        private void SubtractBtn_Click(object sender, EventArgs e)
        {
            if (operation != null)
            {
            }
            else
            {
                if (CalculResultTb.Text != "")
                {
                    firstNumber = CalculResultTb.Text;
                    operation = "-";
                    HistoryRtb.Text += firstNumber + operation;
                    firstOrSecondNumber = false;
                    CalculResultTb.Text = "0";
                }
            }
        }

        private void SumBtn_Click(object sender, EventArgs e)
        {
            if (operation != null)
            {
            }
            else
            {
                if (CalculResultTb.Text != "")
                {
                    operation = "+";
                    firstNumber = CalculResultTb.Text;
                    HistoryRtb.Text += firstNumber + operation;
                    firstOrSecondNumber = false;

                    CalculResultTb.Text = "0";
                }


            }
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (firstOrSecondNumber != true)
            {
                secondNumber = CalculResultTb.Text;
                switch (operation)
                {
                    case "+":
                        result = double.Parse(firstNumber) + double.Parse(secondNumber);
                        break;
                    case "-":
                        result = double.Parse(firstNumber) - double.Parse(secondNumber);
                        break;
                    case "*":
                        result = double.Parse(firstNumber) * double.Parse(secondNumber);
                        break;
                    case "/":
                        result = double.Parse(firstNumber) / double.Parse(secondNumber);
                        break;
                    case "^":
                        result = Math.Pow(double.Parse(firstNumber), double.Parse(secondNumber));
                        break;
                }
                HistoryRtb.Clear();
                firstOrSecondNumber = true;
                CalculResultTb.Text = "0";

                string a = String.Format(firstNumber + operation + secondNumber + "=" +result);
                resultViewList.Items.Add(a);
                operation = null;
            }
            else
            {
                MessageBox.Show("TryAgain");
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (CalculResultTb.Text == "")
            {
                CalculResultTb.Text = "";
            }
            else
            {
                CalculResultTb.Text += "0";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.PreviewKeyDown += new PreviewKeyDownEventHandler(control_PreviewKeyDown);
            }
        }

        void control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                Btn1_Click(sender,e);
            }
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                Btn2_Click(sender, e);
            }
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                Btn3_Click(sender, e);
            }
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                Btn4_Click(sender, e);
            }
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                Btn5_Click(sender, e);
            }
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                Btn6_Click(sender, e);
            }
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                Btn7_Click(sender, e);
            }
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                Btn8_Click(sender, e);
            }
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                Btn9_Click(sender, e);
            }
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                Btn0_Click(sender, e);
            }
            if (e.KeyCode == Keys.Divide)
            {
                DivideBtn_Click(sender, e);
            }
            if (e.KeyCode == Keys.Multiply)
            {
                MultiplyBtn_Click(sender, e);
            }
            if (e.KeyCode == Keys.Subtract)
            {
                SubtractBtn_Click(sender, e);
            }
            if (e.KeyCode == Keys.Add)
            {
                SumBtn_Click(sender, e);
            }
            if (e.KeyCode == Keys.Enter)
            {
                EnterBtn_Click(sender, e);
            }
            if( e.KeyCode == Keys.Decimal)
            {
                DotBtn_Click(sender, e);
            }
            else { 
                e.IsInputKey = true;
            }
        }

        private void resultViewList_Click(object sender, EventArgs e)
        {
            var lastIndex = resultViewList.SelectedIndices.Count - 1;
            var index = resultViewList.SelectedIndices[lastIndex];
            double sum = 0;
            if(index == 0)
            {
                return;
            }

            var lista = resultViewList.Items.Cast<ListViewItem>().Select(item => item.Text).ToList();

            char[] delimitator = new char[] { '=' };
            for (int j = 0; j<=index; j++)
            {
                var a = lista[j].Split(delimitator);
                sum += double.Parse(a[1]);
            }

            resultHistoryTb.Text = sum.ToString();
        }

        private void CBtn_Click(object sender, EventArgs e)
        {
            CalculResultTb.Text = "0";
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            foreach(var dot in CalculResultTb.Text)
            {
                if(dot == '.')
                {
                    return;
                }
            }
            CalculResultTb.Text += ".";
        }
    }
}
