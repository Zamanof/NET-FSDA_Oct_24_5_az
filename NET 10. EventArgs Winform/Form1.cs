namespace NET_10._EventArgs_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            subtractButton.Click += Result;
            multipleButton.Click += Result;
            divideButton.Click += Result;
            addButton.Click += Result;
        }

        private void Result(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            double.TryParse(firstValueTextBox.Text, out double left);
            double.TryParse(secondValueTextBox.Text, out double right);
            if (btn.Text == "Add")
            {
                resultLabel.Text = (left + right).ToString();
            }
            else if (btn.Text == "Subtract")
            {
                resultLabel.Text = (left - right).ToString();
            }
            else if (btn.Text == "Multiple")
            {
                resultLabel.Text = (left * right).ToString();
            }
            else if (btn.Text == "Divide")
            {
                if (right != 0)
                {
                    resultLabel.Text = (left / right).ToString();
                }
                else
                {
                    resultLabel.Text = "Cannot divide by zero";

                }
            }

            firstValueTextBox.Clear();
            secondValueTextBox.Clear();
        }
    }
}
