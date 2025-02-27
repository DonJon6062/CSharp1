using System.Xml.Serialization;

namespace PunchEm
{
    public partial class Form1 : Form
    {
        //set health
        static int playerHealth = 100;
        static int dummyHealth = 100;
        //round counter
        static int roundNumber = 1;
        //wouldn't let me use the resultTextBox without making it a class variable
        private TextBox resultTextBox;
        static TextBox playerHealthTextBox;
        static TextBox dummyHealthTextBox;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Punch 'Em!";

            // Initialize resultTextBox
            resultTextBox = new TextBox();
            // Set the location (gotten by placing a seperate text box)
            resultTextBox.Location = new Point(345, 51);
            // Set the size (gotten by placing a seperate text box)
            resultTextBox.Size = new Size(90, 40);
            // Set the properties
            resultTextBox.ReadOnly = true;
            resultTextBox.Font = new Font("Comic Sans MS", 9, FontStyle.Bold);
            resultTextBox.TextAlign = HorizontalAlignment.Center;
            //add the resultTextBox to the form
            this.Controls.Add(resultTextBox);

            //make health labels for the same reason as resultTextBox, same basics
            playerHealthTextBox = new TextBox();
            playerHealthTextBox.Location = new Point(135, 302);
            playerHealthTextBox.Size = new Size(49, 29);
            playerHealthTextBox.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            playerHealthTextBox.Text = "100";
            playerHealthTextBox.TextAlign = HorizontalAlignment.Center;
            playerHealthTextBox.ReadOnly = true;
            this.Controls.Add(playerHealthTextBox);

            dummyHealthTextBox = new TextBox();
            dummyHealthTextBox.Location = new Point(516, 120);
            dummyHealthTextBox.Size = new Size(49, 29);
            dummyHealthTextBox.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            dummyHealthTextBox.Text = "100";
            dummyHealthTextBox.TextAlign = HorizontalAlignment.Center;
            dummyHealthTextBox.ReadOnly = true;
            this.Controls.Add(dummyHealthTextBox);
            if(Tag == "dummyUI")
            {
                //enable dummy button
                Dummy.Enabled = true;
                dummyAction.Enabled = true;
            }

            //populate calculator type combo box
            playerActions.Items.Add("Rock");
            playerActions.Items.Add("Paper");
            playerActions.Items.Add("Scissors");
            playerActions.SelectedIndex = 0;
        }
        #region playerActions
        private void playerActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playerActions.SelectedIndex == 2)
            {
                moveDescriptions.Text = "Beats Paper.\nLoses to Rock.";
            }
            else if (playerActions.SelectedIndex == 1)
            {
                moveDescriptions.Text = "Beats Rock.\nLoses to Scissors.";
            }
            else if (playerActions.SelectedIndex == 0)
            {
                moveDescriptions.Text = "Beats Scissors.\nLoses to Paper.";
            }
        }
        #endregion
        static int randomNumberGenerator(int min, int max)
        {
            Random random = new Random();
            int randomNumber = random.Next(min, max);
            return randomNumber;
        }

        static string dummyMove()
        {
            string dummyAction = "";
            //dummy generates one or two, paper or scissors
            int dummyMove = randomNumberGenerator(0, 3);
            if (dummyMove == 2)
            {
                dummyAction = "Scissors";
                return dummyAction;
            }
            else if (dummyMove == 1)
            {
                dummyAction = "Paper";
                return dummyAction;
            }
            else if (dummyMove == 0)
            {
                dummyAction = "Rock";
                return dummyAction;
            }
            else
            {
                dummyAction = "Scissors";
                return dummyAction;
            }
        }

        // Have roundEvaluation use the resultTextBox
        static void roundEvaluation(string playerChoice, string enemyChoice, TextBox resultTextBox, int playerHP, int enemyHP)
        {
            string winConfirmation = "You Win!";
            string loseConfirmation = "You Lose!";
            string tieConfirmation = "It's a tie!";
            if (playerChoice == "Rock")
            {
                if (enemyChoice == "Rock")
                {
                    resultTextBox.Text = tieConfirmation;
                }
                else if (enemyChoice == "Paper")
                {
                    resultTextBox.Text = loseConfirmation;
                    //player loses health
                    playerHealth = playerHealth -= 10;
                    //update health text box
                    playerHealthTextBox.Text = playerHealth.ToString();
                }
                else if (enemyChoice == "Scissors")
                {
                    resultTextBox.Text = winConfirmation;
                    //dummy loses health
                    dummyHealth = dummyHealth -= 10;
                    //update health text box
                    dummyHealthTextBox.Text = dummyHealth.ToString();
                }
            }
            else if (playerChoice == "Paper")
            {
                if (enemyChoice == "Rock")
                {
                    resultTextBox.Text = winConfirmation;
                    //dummy loses health
                    dummyHealth = dummyHealth -= 10;
                    //update health text box
                    dummyHealthTextBox.Text = dummyHealth.ToString();
                }
                else if (enemyChoice == "Paper")
                {
                    resultTextBox.Text = tieConfirmation;
                }
                else if (enemyChoice == "Scissors")
                {
                    resultTextBox.Text = loseConfirmation;
                    //player loses health
                    playerHealth = playerHealth -= 10;
                    //update health text box
                    playerHealthTextBox.Text = playerHealth.ToString();
                }
            }
            else if (playerChoice == "Scissors")
            {
                if (enemyChoice == "Rock")
                {
                    resultTextBox.Text = loseConfirmation;
                    //player loses health
                    playerHealth = playerHealth -= 10;
                    //update health text box
                    playerHealthTextBox.Text = playerHealth.ToString();
                }
                else if (enemyChoice == "Paper")
                {
                    resultTextBox.Text = winConfirmation;
                    //dummy loses health
                    dummyHealth = dummyHealth -= 10;
                    //update health text box
                    dummyHealthTextBox.Text = dummyHealth.ToString();
                }
                else if (enemyChoice == "Scissors")
                {
                    resultTextBox.Text = tieConfirmation;
                }
            }
        }

        // Update the Dummy_Click method to pass resultTextBox
        private void Dummy_Click(object sender, EventArgs e)
        {
            string enemyAction = dummyMove();
            dummyAction.Text = enemyAction;
            roundEvaluation(playerActions.Text, enemyAction, resultTextBox, playerHealth, dummyHealth);
            if(playerHealth <= 0)
            {
                MessageBox.Show("You Lose! Try again!");
                playerHealth = 100;
                dummyHealth = 100;
                playerHealthTextBox.Text = playerHealth.ToString();
                dummyHealthTextBox.Text = dummyHealth.ToString();
                roundNumber = 1;
                roundCounter.Text = "Round " + roundNumber;
            }
            else if (dummyHealth <= 0)
            {
                MessageBox.Show("You Win! Nice Job!");
                playerHealth = 100;
                dummyHealth = 100;
                playerHealthTextBox.Text = playerHealth.ToString();
                dummyHealthTextBox.Text = dummyHealth.ToString();
                roundNumber = 1;
                roundCounter.Text = "Round " + roundNumber;
            }
            else 
            {
                roundNumber = roundNumber + 1;
                roundCounter.Text = "Round " + roundNumber;
            }  
        }

        //my cool loop
        private void test_Click(object sender, EventArgs e)
        {
            int scissorsRolled = 0;
            int rockRolled = 0;
            int paperRolled = 0;
            for (int i = 0; i < 1000; i++)
            {
                //rng will never land on max value, used this to figure such out
                int numberGenerated = randomNumberGenerator(0, 3);
                if (numberGenerated == 0)
                {
                    rockRolled = rockRolled + 1;
                }
                else if (numberGenerated == 1)
                {
                    paperRolled = paperRolled + 1;
                }
                else if (numberGenerated == 2)
                {
                    scissorsRolled = scissorsRolled + 1;
                }
            }
            MessageBox.Show("Rock was rolled " + rockRolled + " times.\nPaper was rolled " + paperRolled + " times.\nScissors was rolled " + scissorsRolled + " times.");
        }
    }
}
