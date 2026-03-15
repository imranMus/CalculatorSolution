using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculatorUi
{
    public partial class Form1 : Form
    {
        private Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Read numbers from textboxes
            if (double.TryParse(num1.Text, out double a) &&
                double.TryParse(num2.Text, out double b))
            {
                double result = calculator.Add(a, b);
                numRes.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(num1.Text, out double a) &&
                double.TryParse(num2.Text, out double b))
            {
                double result = calculator.Subtract(a, b);
                numRes.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(num1.Text, out double a) &&
                double.TryParse(num2.Text, out double b))
            {
                double result = calculator.Multiply(a, b);
                numRes.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(num1.Text, out double a) &&
       double.TryParse(num2.Text, out double b))
            {
                try
                {
                    double result = calculator.Divide(a, b);
                    numRes.Text = result.ToString();
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("Cannot divide by zero.");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }
    }
}
