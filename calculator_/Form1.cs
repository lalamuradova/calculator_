using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_
{
    public partial class Form1 : Form
    {
        public static string Conteyner { get; set; } = string.Empty;
        public static string Operation { get; set; } = string.Empty;
        public static bool Period { get; set; } = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.BackColor = Color.FromArgb(37, 37, 38);
            btn0.BackColor = Color.FromArgb(51, 51, 51);
            btn1.BackColor = Color.FromArgb(51, 51, 51);
            btn2.BackColor = Color.FromArgb(51, 51, 51);
            btn3.BackColor = Color.FromArgb(51, 51, 51);
            btn4.BackColor = Color.FromArgb(51, 51, 51);
            btn5.BackColor = Color.FromArgb(51, 51, 51);
            btn6.BackColor = Color.FromArgb(51, 51, 51);
            btn7.BackColor = Color.FromArgb(51, 51, 51);
            btn8.BackColor = Color.FromArgb(51, 51, 51);
            btn9.BackColor = Color.FromArgb(51, 51, 51);
            
            Deletebtn.BackColor = Color.FromArgb(125, 91, 166);
            Multbtn.BackColor = Color.FromArgb(125, 91, 166);
            Subbtn.BackColor = Color.FromArgb(125, 91, 166);
            Dividebtn.BackColor = Color.FromArgb(125, 91, 166);
            Sumbtn.BackColor = Color.FromArgb(125, 91, 166);

            btnshow.BackColor = Color.FromArgb(100, 49, 115);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Resultlbl.Text += button.Text;
        }

        private void Multbtn_Click(object sender, EventArgs e)
        {           

            if (calculatelbl.Text == string.Empty || Period == true) 
            {               
                Conteyner = Resultlbl.Text;
                Operation = "*";
                calculatelbl.Text = Resultlbl.Text + "*";
                Period = false;
                Resultlbl.Text = string.Empty;
            }
            else
            {
                Calculate();
                Operation = "*";
            }
        }

        private void Dividebtn_Click(object sender, EventArgs e)
        {            

            if (calculatelbl.Text == string.Empty || Period == true)
            {                             
                Conteyner = Resultlbl.Text; 
                Operation = "/";
                calculatelbl.Text = Resultlbl.Text + "/";
                Period = false;
                Resultlbl.Text = string.Empty;
            }
            else
            {
                Calculate();
                Operation = "/";
            }
            
        }

        private void Sumbtn_Click(object sender, EventArgs e)
        {           
            
            if (calculatelbl.Text == string.Empty || Period == true)
            {              
                Conteyner = Resultlbl.Text;
                Operation = "+";
                calculatelbl.Text = Resultlbl.Text + "+";
                Period = false;
                Resultlbl.Text = string.Empty;
            }
            else
            {
                Calculate();
                Operation = "+";
            }
        }

        private void Subbtn_Click(object sender, EventArgs e)
        {
            if (calculatelbl.Text == string.Empty || Period == true)
            {
                Conteyner = Resultlbl.Text;
                Operation = "-";
                calculatelbl.Text = Resultlbl.Text + "-";
                Period = false;
                Resultlbl.Text = string.Empty;
            }
            else
            {
                if (Resultlbl.Text != null)
                {
                    Calculate();
                    Operation = "-";
                }
            }
        }
        public void Calculate()
        {
            double num1 = double.Parse(Conteyner);
            if (Resultlbl.Text != string.Empty)
            {
                double num2 = double.Parse(Resultlbl.Text);

                if (Operation == "*")
                {
                    calculatelbl.Text = (num1 * num2).ToString();
                }
                else if (Operation == "/")
                {
                    calculatelbl.Text = (num1 / num2).ToString();
                }
                else if (Operation == "+")
                {
                    calculatelbl.Text = (num1 + num2).ToString();
                }
                else
                {
                    calculatelbl.Text = (num1 - num2).ToString();
                }
                Conteyner = calculatelbl.Text;
                Resultlbl.Text = string.Empty;
            }
            
        }
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            calculatelbl.Text = string.Empty;
            Resultlbl.Text = string.Empty;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string text = Conteyner + Operation + Resultlbl.Text;
            Calculate();
            Resultlbl.Text = calculatelbl.Text;
            calculatelbl.Text = text + "=";
            Period = true;
        }
    }
}
