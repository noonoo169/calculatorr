using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Fix tiếp lỗi không công trừ liên tiếp được 

namespace Calculator
{
    public enum Option
    {
        None,
        Add,
        Subtract,
        Multiply,
        Divide
    }
    public partial class Calculator : Form
    {
        private double result;
        private bool currentNum;
        private bool flag;
        private bool checkDenominator;
        private bool secondNum;
        private Option Op;
        public Calculator()
        {
            InitializeComponent();
            result = 0;
            flag = true;
            Op = Option.None;
            checkDenominator = true;
            currentNum = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(this.tbResult.Text == "0")
            {
                return;
            }
            if( this.flag == true)
            {
                this.tbResult.Text += "0";
            }
            else
            {
                this.tbResult.Text = "0";
            }
            this.flag = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (this.tbResult.Text == "0")
            {
                this.tbResult.Text = "";
            }
            if (this.flag == true)
            {
                this.tbResult.Text += "1";
            }
            else
            {
                this.tbResult.Text = "1";
            }
            this.flag = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (this.tbResult.Text == "0")
            {
                this.tbResult.Text = "";
            }
            if (this.flag == true)
            {
                this.tbResult.Text += "2";
            }
            else
            {
                this.tbResult.Text = "2";
            }
            this.flag = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (this.tbResult.Text == "0")
            {
                this.tbResult.Text = "";
            }
            if (this.flag == true)
            {
                this.tbResult.Text += "3";
            }
            else
            {
                this.tbResult.Text = "3";
            }
            this.flag = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (this.tbResult.Text == "0")
            {
                this.tbResult.Text = "";
            }
            if (this.flag == true)
            {
                this.tbResult.Text += "4";
            }
            else
            {
                this.tbResult.Text = "4";
            }
            this.flag = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (this.tbResult.Text == "0")
            {
                this.tbResult.Text = "";
            }
            if (this.flag == true)
            {
                this.tbResult.Text += "5";
            }
            else
            {
                this.tbResult.Text = "5";
            }
            this.flag = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (this.tbResult.Text == "0")
            {
                this.tbResult.Text = "";
            }
            if (this.flag == true)
            {
                this.tbResult.Text += "6";
            }
            else
            {
                this.tbResult.Text = "6";
            }
            this.flag = true;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (this.tbResult.Text == "0")
            {
                this.tbResult.Text = "";
            }
            if (this.flag == true)
            {
                this.tbResult.Text += "7";
            }
            else
            {
                this.tbResult.Text = "7";
            }
            this.flag = true;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (this.tbResult.Text == "0")
            {
                this.tbResult.Text = "";
            }
            if (this.flag == true)
            {
                this.tbResult.Text += "8";
            }
            else
            {
                this.tbResult.Text = "8";
            }
            this.flag = true;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (this.tbResult.Text == "0")
            {
                this.tbResult.Text = "";
            }
            if (this.flag == true)
            {
                this.tbResult.Text += "9";
            }
            else
            {
                this.tbResult.Text = "9";
            }
            this.flag = true;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (currentNum == true)
            {
                this.tbBieuThuc.Text = string.Format("{0}", this.result) + "+";
            }
            else
            {
                this.result += Convert.ToDouble(this.tbResult.Text);
                this.tbBieuThuc.Text = string.Format("{0}", this.result) + "+";
                this.tbResult.Text = string.Format("{0}", this.result);
            }
            /*this.result += Convert.ToDouble(this.tbResult.Text);
            this.tbBieuThuc.Text = string.Format("{0}", this.result) + "+";
            this.tbResult.Text = string.Format("{0}", this.result);*/
            this.flag = false;
            Op = Option.Add;
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if(secondNum == false)
            {
                this.result = Convert.ToDouble(this.tbResult.Text);
            }
            else
            {
                this.result -= Convert.ToDouble(this.tbResult.Text);
            }
            this.tbBieuThuc.Text = string.Format("{0}", this.result) + "-";
            this.tbResult.Text = string.Format("{0}", this.result);
            this.flag = false;
            this.secondNum = true;
            Op = Option.Subtract;
        }
        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (secondNum == false)
            {
                this.result = Convert.ToDouble(this.tbResult.Text);
            }
            else
            {
                this.result *= Convert.ToDouble(this.tbResult.Text);
            }
            this.tbBieuThuc.Text = string.Format("{0}", this.result) + "*";
            this.tbResult.Text = string.Format("{0}", this.result);
            this.flag = false;
            this.secondNum = true;
            Op = Option.Multiply;
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (secondNum == false)
            {
                this.result = Convert.ToDouble(this.tbResult.Text);
                this.tbBieuThuc.Text = string.Format("{0}", this.result) + "/";
                this.tbResult.Text = string.Format("{0}", this.result);
            }
            else
            {
                if (this.tbResult.Text != "0")
                {
                    this.result /= Convert.ToDouble(this.tbResult.Text);
                    this.tbBieuThuc.Text = string.Format("{0}", this.result) + "/";
                    this.tbResult.Text = string.Format("{0}", this.result);
                }
                else
                {
                    this.tbBieuThuc.Text = "Cannot divide by zero";
                }
            }
            
            this.flag = false;
            this.secondNum = true;
            Op = Option.Divide;
        }
        private void btnBang_Click(object sender, EventArgs e)
        {
            this.tbBieuThuc.Text += this.tbResult.Text + " = ";
            if (Op == Option.Add)
            {
                this.result += Convert.ToDouble(this.tbResult.Text);
            }
            if (Op == Option.Subtract)
            {
                this.result -= Convert.ToDouble(this.tbResult.Text);
            }
            if (Op == Option.Multiply)
            {
                this.result *= Convert.ToDouble(this.tbResult.Text);
            }
            if (Op == Option.Divide)
            {
                if(this.tbResult.Text != "0")
                {
                    this.result /= Convert.ToDouble(this.tbResult.Text);
                }
                else
                {
                    checkDenominator = false;
                }
            }
            if( checkDenominator == true)
            {
                this.tbResult.Text = string.Format("{0}", this.result);
            }
            else
            {
                this.tbBieuThuc.Text = "Cannot divide by zero";
            }
            this.flag = false;
            this.checkDenominator = true;
            this.result = 0;
            this.secondNum = false;
            this.Op = Option.None;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            this.result = 0;
            this.secondNum = false;
            this.tbResult.Text = "";
            this.tbBieuThuc.Text = "";
        }
    }
}
