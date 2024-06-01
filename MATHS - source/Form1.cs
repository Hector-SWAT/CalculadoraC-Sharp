using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MATHS___source
{
    //CODIGO DE SWAT

    public partial class maths : Form
    {
        double first;
        double second;
        double result;
        string operation;
        public maths()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void number0_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "0";
        }

        private void number1_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "1";
        }

        private void number2_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "2";
        }

        private void number3_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "3";
        }

        private void number4_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "4";
        }

        private void number5_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "5";
        }

        private void number6_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "6";
        }

        private void number7_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "7";
        }

        private void number8_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "8";
        }

        private void number9_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "9";
        }

        private void numberPI_click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "3,14159265";
        }

        private void numberten_click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "10";
        }

        private void number100_click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "100";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + ",";
        }

        private void add_Click(object sender, EventArgs e)
        {
            operation = "+";
            first = double.Parse(screen.Text);
            screen.Clear();
        }

        private void subs_Click(object sender, EventArgs e)
        {
            operation = "-";
            first = double.Parse(screen.Text);
            screen.Clear();
        }

        private void mult_Click(object sender, EventArgs e)
        {
            operation = "*";
            first = double.Parse(screen.Text);
            screen.Clear();
        }

        private void div_Click(object sender, EventArgs e)
        {
            operation = "/";
            first = double.Parse(screen.Text);
            screen.Clear();
        }

        private void module_Click(object sender, EventArgs e)
        {
            operation = "%";
            first = double.Parse(screen.Text);
            screen.Clear();
        }

        private void equals_Click(object sender, EventArgs e)
        {
            second = double.Parse(screen.Text);
            switch (operation)
            {
                case "+":
                    result = first + second;
                    screen.Text = result.ToString();
                    break;

                case "-":
                    result = first - second;
                    screen.Text = result.ToString();
                    break;

                case "*":
                    result = first * second;
                    screen.Text = result.ToString();
                    break;

                case "/":
                    result = first / second;
                    screen.Text = result.ToString();
                    break;
                
                case "%":
                    result = first % second;
                    screen.Text = result.ToString();
                    break;
            }
        }

        private void ce_Click(object sender, EventArgs e)
        {
            screen.Clear();
        }
    }
}
