using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2._0
{
    public partial class Form1 : Form
    {

        string _firstNumber, _secondNumber;
        char _actionSign = ' ';



        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_actionSign == ' ')
            {
                _firstNumber = (int.Parse(_firstNumber) * -1).ToString();
                tbScore.Text = _firstNumber;
            }
            else
            {
                _secondNumber = (int.Parse(_secondNumber) * -1).ToString();
                tbScore.Text = _secondNumber;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbScore2_TextChanged(object sender, EventArgs e)
        {

        }

        private void b0_Click(object sender, EventArgs e)
        {
            Action(0);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Action(1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Action(2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Action(3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Action(4);
        }
        private void b5_Click(object sender, EventArgs e)
        {
            Action(5);
        }
        private void b6_Click(object sender, EventArgs e)
        {
            Action(6);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Action(7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Action(8);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Action(9);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (_firstNumber == null)
            {

            }
            else
            {
                _actionSign = '+';
                UpdateSecondText();
            }
        }
        private void bSub_Click(object sender, EventArgs e)
        {
            if (_firstNumber == null)
            {

            }
            else
            {
                _actionSign = '-';
                UpdateSecondText();
            }
        }

        private void bMulti_Click(object sender, EventArgs e)
        {
            if (_firstNumber == null)
            {

            }
            else
            {
                _actionSign = 'x';
                UpdateSecondText();
            }
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            if (_firstNumber == null)
            {

            }
            else
            {
                _actionSign = '/';
                UpdateSecondText();
            }
        }

        private void bRoot_Click(object sender, EventArgs e)
        {
            if (_firstNumber == null)
            {

            }
            else if (_secondNumber == null)
            {
                string sqrtNumber = (Math.Sqrt(double.Parse(_firstNumber))).ToString();
                tbScore.Text = sqrtNumber;
                tbScore2.Text = "√ " + _firstNumber + " =";
                _firstNumber = sqrtNumber;
            }
            else
            {
                string sqrtNumber2 = (Math.Sqrt(double.Parse(_secondNumber))).ToString();
                tbScore.Text = sqrtNumber2;
                tbScore2.Text = _firstNumber + " " + _actionSign + " √ " + _secondNumber;
                _secondNumber = sqrtNumber2;
            }
        }

        private void bPower_Click(object sender, EventArgs e)
        {
            if (_firstNumber == null)
            {

            }
           
            else if (_secondNumber == null)
            {
                _firstNumber = (Math.Pow(double.Parse(_firstNumber), 2)).ToString();
                tbScore.Text = _firstNumber;

                ResetSecondNumber();
                tbScore2.Text = _firstNumber + "^2";
            }
            else
            {
                _secondNumber = (Math.Pow(double.Parse(_secondNumber), 2)).ToString();
                tbScore.Text = _secondNumber;

                
                tbScore2.Text = _firstNumber + " " + _actionSign + "^2";
            }
        }

        private void bFraction_Click(object sender, EventArgs e)
        {
            if (_firstNumber == null)
            {

            }
            else
            {
                tbScore.Text = (1 / double.Parse(_firstNumber)).ToString();
                tbScore2.Text = "1/" + _firstNumber;
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            if (_actionSign == ' ')
            {
                if (_firstNumber == null)
                {

                }
                else if (_firstNumber.Length > 1)
                {
                    _firstNumber = _firstNumber.Remove(_firstNumber.Length - 1);
                    tbScore.Text = _firstNumber;
                }
                else
                {
                    ResetSecondNumber();
                    tbScore.Text = "0";
                }
            }

            else
            {
                if (_secondNumber == null)
                {

                }
                else if (_secondNumber.Length > 1)
                {
                    _secondNumber = _secondNumber.Remove(_secondNumber.Length -1);
                    tbScore.Text = _secondNumber;
                }
                else
                {
                    _secondNumber = null;
                    tbScore.Text = "0";
                }
            }
        }

        private void bC_Click(object sender, EventArgs e)
        {
            ResetSecondNumber();
            _firstNumber = null;
            tbScore.Text = "0";
            UpdateSecondText();
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            if (_actionSign == ' ')
            {
                ResetSecondNumber();
                tbScore.Text = "0";
            }
            else
            {
                _secondNumber = null;
                tbScore.Text = "0";
            }
        }

        private void bPerCent_Click(object sender, EventArgs e)
        {
            if (_actionSign == ' ')
            {
                ResetSecondNumber();
                tbScore.Text = "0";
            }
            else
            {
                _secondNumber = (double.Parse(_firstNumber) / 100).ToString();
                tbScore.Text = _secondNumber;
            }
        }

        private void bDecimal_Click(object sender, EventArgs e)
        {
            if (_actionSign == ' ')
            {
                _firstNumber += ",";
                tbScore.Text = _firstNumber;
            }
            else
            {
                _secondNumber += ",";
                tbScore.Text = _secondNumber;
            }
        }

        private void bScore_Click(object sender, EventArgs e)
        {
            if (_secondNumber == "0" && _actionSign == '/')
            {
                Error();
            }
            else if (_secondNumber == null)
            {
                Error();
            }
            else
            {
                tbScore2.Text = _firstNumber + " " + _actionSign + " " + _secondNumber + " =";
                switch (_actionSign)
                {
                    case ('+'):
                        _firstNumber = (double.Parse(_firstNumber) + double.Parse(_secondNumber)).ToString();
                        tbScore.Text = _firstNumber;
                        break;
                    case ('-'):
                        _firstNumber = (double.Parse(_firstNumber) - double.Parse(_secondNumber)).ToString();
                        tbScore.Text = _firstNumber;
                        break;
                    case ('x'):
                        _firstNumber = (double.Parse(_firstNumber) * double.Parse(_secondNumber)).ToString();
                        tbScore.Text = _firstNumber;
                        break;
                    case ('/'):
                        _firstNumber = (double.Parse(_firstNumber) / double.Parse(_secondNumber)).ToString();
                        tbScore.Text = _firstNumber;
                        break;
                }
            }
            
            ResetSecondNumber();
        }

        void Action(double number)
        {
            if (_actionSign == ' ')
            {
                _firstNumber += number;
                tbScore.Text = _firstNumber;
            }
            else
            {
                _secondNumber += number;
                tbScore.Text = _secondNumber;
            }
        }

        void ResetSecondNumber()
        {
            
            _secondNumber = null;
            _actionSign = ' ';
        }
        void UpdateSecondText()
        {
            tbScore2.Text = _firstNumber + " " + _actionSign;
        }
        void Error()
        {
            _firstNumber = null;
            tbScore.Text = "Error";
            ResetSecondNumber();
        }
    }
}
