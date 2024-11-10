namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        private CalculatorClass cal;
        private double num1, num2;
        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxInput2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);
            
            switch (cbOperator.SelectedItem.ToString())
            {
                case "+":
                    cal.CalculateEvent += cal.GetSum;
                    lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                    cal.CalculateEvent -= cal.GetSum;
                    break;
                case "-":
                    cal.CalculateEvent += cal.GetDifference;
                    lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                    cal.CalculateEvent -= cal.GetDifference;
                    break;
                case "*":
                    cal.CalculateEvent += cal.GetProduct;
                    lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                    cal.CalculateEvent -= cal.GetProduct;
                    break;
                case "/":
                    try
                    {
                        cal.CalculateEvent += cal.GetQuotient;
                        lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                        cal.CalculateEvent -= cal.GetQuotient;
                    }
                    catch (DivideByZeroException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    MessageBox.Show("Please select a valid operator.", "Operator Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }


    public delegate T Formula<T>(T arg1, T arg2);
    public class CalculatorClass
    {
        public Formula<double> calculateOperation;

        public event Formula<double> CalculateEvent
        {
            add
            {
                calculateOperation += value;
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                calculateOperation -= value;
                Console.WriteLine("Removed the Delegate");
            }
        }
        public double GetSum(double num1, double num2) => num1 + num2;

        public double GetDifference(double num1, double num2) => num1 - num2;

        public double GetProduct(double num1, double num2) => num1 * num2;
        public double GetQuotient(double num1, double num2) => num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Cannot divide by zero.");
    }
}