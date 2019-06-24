using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private readonly Calculator calculatorProcessor;

        public MainForm()
        {
            InitializeComponent();
            calculatorProcessor = new Calculator();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var number = long.Parse(tbx_Number.Text);
            var result = calculatorProcessor.Add(number);
            tbx_Result.Text = result.ToString();
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            var number = long.Parse(tbx_Number.Text);
            var result = calculatorProcessor.Substract(number);
            tbx_Result.Text = result.ToString();
        }

        private void MultButton_Click(object sender, EventArgs e)
        {
            var number = long.Parse(tbx_Number.Text);
            var result = calculatorProcessor.Multiply(number);
            tbx_Result.Text = result.ToString();
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            var number = long.Parse(tbx_Number.Text);
            var result = calculatorProcessor.Divide(number);
            tbx_Result.Text = result.ToString();
        }
    }
}
