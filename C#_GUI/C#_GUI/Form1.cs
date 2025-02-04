namespace C__GUI
{
    public partial class Form1 : Form
    {
        private string appName = "Fun Form"; // Application name

        private bool crunchySwitch = true;
        private bool soggySwitch = true;
        private int ssn = 0;
        private bool ssnInput;

        public Form1()
        {
            InitializeComponent();
            this.Text = appName;
        }

        private void crunchyOption_CheckedChanged(object sender, EventArgs e)
        {
            //enable message
            crunchySwitch = true;
            //stop two message boxes from appearing
            soggySwitch = false;
            if (crunchySwitch == true)
            {
                MessageBox.Show("Really?");
            }
        }

        private void soggyOption_CheckedChanged(object sender, EventArgs e)
        {
            soggySwitch = true;
            //prevents message boxes from layering
            crunchySwitch = false;
            if (soggySwitch == true)
            {
                MessageBox.Show("Honestly?");
            }
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YEOWCH!");
        }

        private void noClickButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tee hee! That tickles!");
        }

        private void firstNumTextBox_TextChanged(object sender, EventArgs e)
        {
            //get first number
            double numberOne = double.Parse(firstNumTextBox.Text);
        }
        private void secondNumTextBox_TextChanged(object sender, EventArgs e)
        {
            //get second number
            double numberTwo = double.Parse(secondNumTextBox.Text);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //get first number
            double numberOne = double.Parse(firstNumTextBox.Text);
            //get second number
            double numberTwo = double.Parse(secondNumTextBox.Text);
            //add and aign to var
            double result = numberOne + numberTwo;
            //display var
            readOnlyBox.Text = result.ToString();
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            //get first number
            double numberOne = double.Parse(firstNumTextBox.Text);
            //get second number
            double numberTwo = double.Parse(secondNumTextBox.Text);
            //add and aign to var
            double result = numberOne - numberTwo;
            //display var
            readOnlyBox.Text = result.ToString();
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            //get first number
            double numberOne = double.Parse(firstNumTextBox.Text);
            //get second number
            double numberTwo = double.Parse(secondNumTextBox.Text);
            //add and aign to var
            double result = numberOne * numberTwo;
            //display var
            readOnlyBox.Text = result.ToString();
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            //get first number
            double numberOne = double.Parse(firstNumTextBox.Text);
            //get second number
            double numberTwo = double.Parse(secondNumTextBox.Text);
            //add and aign to var
            double result = numberOne / numberTwo;
            //display var
            readOnlyBox.Text = result.ToString();
        }

        private void ssnTextBox_TextChanged(object sender, EventArgs e)
        {
            ssnInput = true;
            ssn = int.Parse(ssnTextBox.Text);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //taunt user if ssn has changed
            if (ssnInput == true)
            {
                MessageBox.Show("HAHAHA I HAVE YOUR SSN! IT'S " + ssn);
            }
            else
            {
                MessageBox.Show("There's a big, red 'X' in that corner... ");
            }
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you know what this is");
        }
    }
}
