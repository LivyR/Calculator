using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operations = "";
        bool isOperations = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperations))
                textBox1.Clear();

            textBox1.Text = textBox1.Text + "1";
            isOperations = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperations))
                textBox1.Clear();

            textBox1.Text = textBox1.Text + "2";
            isOperations = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperations))
                textBox1.Clear();

            textBox1.Text = textBox1.Text + "3";
            isOperations = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperations))
                textBox1.Clear();

            textBox1.Text = textBox1.Text + "4";
            isOperations = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperations))
                textBox1.Clear();

            textBox1.Text = textBox1.Text + "5";
            isOperations = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperations))
                textBox1.Clear();

            textBox1.Text = textBox1.Text + "6";
            isOperations = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperations))
                textBox1.Clear();

            textBox1.Text = textBox1.Text + "7";
            isOperations = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperations))
                textBox1.Clear();

            textBox1.Text = textBox1.Text + "8";
            isOperations = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperations))
                textBox1.Clear();

            textBox1.Text = textBox1.Text + "9";
            isOperations = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperations))
                textBox1.Clear();

            textBox1.Text = textBox1.Text + "0";
            isOperations = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch(operations)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void operators_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operations = button.Text;
            result = Double.Parse(textBox1.Text);
            isOperations = true;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;

        }

    }
}
