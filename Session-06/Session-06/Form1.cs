using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_06
{
    public partial class Form1 : Form
    {
        private Calculation.Operators CurrOperator;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            textBox1.ReadOnly = true;
        }

        private void buttonNumberClick(object sender, EventArgs e)
        {
            Button helper = (Button)sender;
            textBox1.Text += helper.Text;
        }

        //Equal
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            Calculation.Equal equal  = new Calculation.Equal();
            double[] numbers= equal.ConvertStringToNumbers(textBox1.Text);
            textBox1.Text=equal.ExecutEqual(numbers).ToString();

        }

        //Add
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CurrOperator = new Calculation.Add();
            textBox1.Text += CurrOperator.OperatorsToString();
        }

        //Subb
        private void buttonSub_Click(object sender, EventArgs e)
        {
            CurrOperator = new Calculation.Subtraction();
            textBox1.Text += CurrOperator.OperatorsToString();
        }

        //SQRT
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            CurrOperator = new Calculation.Root();
            textBox1.Text += CurrOperator.OperatorsToString();

        }

        //Pow
        private void buttonPow_Click(object sender, EventArgs e)
        {
            CurrOperator = new Calculation.Power();
            textBox1.Text += CurrOperator.OperatorsToString();
        }

        //Mul
        private void buttonMul_Click(object sender, EventArgs e)
        {
            CurrOperator = new Calculation.Multiplication();
            textBox1.Text += CurrOperator.OperatorsToString();
        }

        //Div
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            CurrOperator = new Calculation.Division();
            textBox1.Text += CurrOperator.OperatorsToString();
        }
    }
}
