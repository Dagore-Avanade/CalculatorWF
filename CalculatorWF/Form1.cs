using System.Data;

namespace CalculatorWF
{
    public partial class Calculadora : Form
    {
        readonly char[] symbols =
        {
            ',', '+', '-', 'x', '/', '%'
        };
        readonly DataTable dataTable = new();
        public Calculadora()
        {
            InitializeComponent();
        }
        void ClearBtn_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "0";
        }
        void InsertNumberBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string number = btn.Text;

            if (displayLabel.Text == "0" || displayLabel.Text == "Error")
            {
                displayLabel.Text = number;
            }
            else
            {
                displayLabel.Text += number;
            }
        }
        void InsertSymbolBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string symbol = button.Text;

            if (displayLabel.Text != "Error" && !EndsWithOperator(displayLabel.Text))
            {
                displayLabel.Text += symbol;
            }
        }
        void EqualsBtn_Click(object sender, EventArgs e)
        {
            if (!EndsWithOperator(displayLabel.Text))
            {
                try
                {
                    string expression = displayLabel.Text
                        .Replace("MOD", "%")
                        .Replace('x', '*')
                        .Replace(',', '.');
                    displayLabel.Text = dataTable.Compute(expression, "").ToString();
                }
                catch
                {
                    displayLabel.Text = "Error";
                }
            }
        }
        void DeleteLastBtn_Click(object sender, EventArgs e)
        {
            if (displayLabel.Text.Length > 1)
            {
                displayLabel.Text = displayLabel.Text.Substring(0, displayLabel.Text.Length - 1);
            }
            else
            {
                displayLabel.Text = "0";
            }
        }
        void InsertParenthesisBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string text = btn.Text;
            
            if (displayLabel.Text == "0" || displayLabel.Text == "Error")
            {
                displayLabel.Text = text;
            }
            else
            {
                displayLabel.Text += text;
            }
        }
        bool EndsWithOperator(string s)
        {
            char lastChar = s.LastOrDefault();
            return Array.Exists(symbols, c => lastChar == c);
        }
    }
}