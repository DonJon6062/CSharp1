namespace semiFunctional
{
    public partial class Form1 : Form
    {
        private double lastConvertedValue;
        public Form1()
        {
            InitializeComponent();
            this.Text = "QuickCalculations";

            //populate calculator type combo box
            calculationSelector.Items.Add("Calculator");
            calculationSelector.Items.Add("Temperature Converter");
            calculationSelector.SelectedIndex = 0;

            //populate temperature type combo box
            temperatureType.Items.Add("Celsius to Fahrenheit");
            temperatureType.Items.Add("Farenheit to Celsius");
            temperatureType.SelectedIndex = 0;
        }

        private void calculationSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (calculationSelector.SelectedIndex == 1)
            {
                //temperature converter mode
                if (addButton.Visible == true)
                {
                    addButton.Visible = false;
                }
                if (subtractButton.Visible == true)
                {
                    subtractButton.Visible = false;
                }
                if (multiplyButton.Visible == true)
                {
                    multiplyButton.Visible = false;
                }
                if (divideButton.Visible == true)
                {
                    divideButton.Visible = false;
                }
                if (numTwo.Visible == true)
                {
                    numTwo.Visible = false;
                }
                if (temperatureType.Visible == false)
                {
                    temperatureType.Visible = true;
                }
                if (convertTemp.Visible == false)
                {
                    convertTemp.Visible = true;
                }
            }
            else
            {
                //calculator mode
                if (addButton.Visible == false)
                {
                    addButton.Visible = true;
                }
                if (subtractButton.Visible == false)
                {
                    subtractButton.Visible = true;
                }
                if (multiplyButton.Visible == false)
                {
                    multiplyButton.Visible = true;
                }
                if (divideButton.Visible == false)
                {
                    divideButton.Visible = true;
                }
                if (numTwo.Visible == false)
                {
                    numTwo.Visible = true;
                }
                if (temperatureType.Visible == true)
                {
                    temperatureType.Visible = false;
                }
                if (convertTemp.Visible == true)
                {
                    convertTemp.Visible = false;
                }
            }
        }
        private void convertTemp_Click(object sender, EventArgs e)
        {
            // Get the input temperature
            double inputTemperature = double.Parse(numOne.Text);

            // Perform conversion based on the selected type
            if (temperatureType.SelectedIndex == 0)
            {
                lastConvertedValue = (inputTemperature * 9 / 5) + 32; // Celsius to Fahrenheit
            }
            else
            {
                lastConvertedValue = (inputTemperature - 32) * 5 / 9; // Fahrenheit to Celsius
            }
            // Display the converted value
            resultText.Text = lastConvertedValue.ToString("F2");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //get first number
            double firstNumber = double.Parse(numOne.Text);
            //get second number
            double secondNumber = double.Parse(numTwo.Text);
            //add and assign to var
            double result = firstNumber + secondNumber;
            //display var
            resultText.Text = result.ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            //get first number
            double firstNumber = double.Parse(numOne.Text);
            //get second number
            double secondNumber = double.Parse(numTwo.Text);
            //subtract and assign to var
            double result = firstNumber - secondNumber;
            //display var
            resultText.Text = result.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            //get first number
            double firstNumber = double.Parse(numOne.Text);
            //get second number
            double secondNumber = double.Parse(numTwo.Text);
            //multiply and assign to var
            double result = firstNumber * secondNumber;
            //display var
            resultText.Text = result.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            //get first number
            double numberOne = double.Parse(numOne.Text);
            //get second number
            double numberTwo = double.Parse(numTwo.Text);
            //don't allow division by zero
            if (numberTwo == 0)
            {
                MessageBox.Show("You can't do that, silly!");
            }
            //divide and assign to var
            double result = numberOne / numberTwo;
            //display var
            resultText.Text = result.ToString();
        }
    }
}
