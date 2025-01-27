namespace C__GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crunchyOption_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Really?");
        }

        private void soggyOption_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Honestly?");
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close program

        }
    }
}
