using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MayTinh
{
    
    public partial class Form1 : Form
    {
        double values = 0;
        string op ;
        bool flag = false; // xoá số cũ sau khi bấm phép tính 
        public Form1()
        {
            InitializeComponent();
        }   

        private void btn_Click(object sender, EventArgs e)
        {
            if( ( result.Text == "0" ) || ( flag == true ) )
            {
                result.Text = "";
            }
            Button b = (Button)sender;
            if( b.Text == ".")
            {
                if(!result.Text.Contains("."))
                {
                    result.Text = result.Text + b.Text;
                }
            }
            else
            {
                result.Text = result.Text + b.Text;
            }
            flag = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Expression.Text = "";
            result.Text = "0";
            values = 0;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if ( values != 0)
            {
                btnEqual.PerformClick();
            }
            else
            {
                values = Convert.ToDouble(result.Text);
            }
            op = b.Text;
            Expression.Text = (values).ToString() + op ;
            flag = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Expression.Text += result.Text ;

            if ( op == "+" )
            {
                result.Text = (values + Convert.ToDouble(result.Text)).ToString();
            }
            if ( op == "-" )
            {
                result.Text = (values - Convert.ToDouble(result.Text)).ToString();
            }
            if ( op == "*" )
            {
                result.Text = (values * Convert.ToDouble(result.Text)).ToString();
            }           
            if ( op == "/" )
            {
                if ( result.Text != "0" )
                {
                    result.Text = (values / Convert.ToDouble(result.Text)).ToString();
                }
                else
                {
                    result.Text = "Cannot divide by zero";
                    btnClear.PerformClick();
                }
            }
            values = Convert.ToDouble(result.Text);
            op = "";
        }

    }
}
