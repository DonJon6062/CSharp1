namespace C__GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clickButton = new Button();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            ssnTextBox = new TextBox();
            ssnLabel = new Label();
            label2 = new Label();
            bdayTextBox = new TextBox();
            bdayLabel = new Label();
            soggyOption = new RadioButton();
            crunchyOption = new RadioButton();
            noClickButton = new Button();
            readOnlyBox = new TextBox();
            confirmButton = new Button();
            secondNumTextBox = new TextBox();
            firstNumTextBox = new TextBox();
            exitButton = new Button();
            subtractionButton = new Button();
            multiplicationButton = new Button();
            divisionButton = new Button();
            SuspendLayout();
            // 
            // clickButton
            // 
            clickButton.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            clickButton.Location = new Point(154, 288);
            clickButton.Name = "clickButton";
            clickButton.Size = new Size(542, 132);
            clickButton.TabIndex = 0;
            clickButton.Text = "Click Me!";
            clickButton.UseVisualStyleBackColor = true;
            clickButton.Click += clickButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(13, 12);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(84, 32);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            nameLabel.Click += nameLabel_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.Location = new Point(12, 55);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Type Here!";
            nameTextBox.Size = new Size(253, 35);
            nameTextBox.TabIndex = 2;
            // 
            // ssnTextBox
            // 
            ssnTextBox.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ssnTextBox.Location = new Point(615, 55);
            ssnTextBox.Name = "ssnTextBox";
            ssnTextBox.PlaceholderText = "Type Here!";
            ssnTextBox.Size = new Size(253, 35);
            ssnTextBox.TabIndex = 4;
            ssnTextBox.TextChanged += ssnTextBox_TextChanged;
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ssnLabel.Location = new Point(617, 12);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new Size(70, 32);
            ssnLabel.TabIndex = 3;
            ssnLabel.Text = "SSN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 94);
            label2.Name = "label2";
            label2.Size = new Size(84, 32);
            label2.TabIndex = 5;
            label2.Text = "Mood:";
            // 
            // bdayTextBox
            // 
            bdayTextBox.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdayTextBox.Location = new Point(615, 144);
            bdayTextBox.Name = "bdayTextBox";
            bdayTextBox.PlaceholderText = "Type Here!";
            bdayTextBox.Size = new Size(253, 35);
            bdayTextBox.TabIndex = 8;
            // 
            // bdayLabel
            // 
            bdayLabel.AutoSize = true;
            bdayLabel.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bdayLabel.Location = new Point(617, 101);
            bdayLabel.Name = "bdayLabel";
            bdayLabel.Size = new Size(140, 32);
            bdayLabel.TabIndex = 7;
            bdayLabel.Text = "Birthday:";
            // 
            // soggyOption
            // 
            soggyOption.AutoSize = true;
            soggyOption.Font = new Font("Jokerman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            soggyOption.Location = new Point(12, 140);
            soggyOption.Name = "soggyOption";
            soggyOption.Size = new Size(116, 39);
            soggyOption.TabIndex = 9;
            soggyOption.TabStop = true;
            soggyOption.Text = "Soggy";
            soggyOption.UseVisualStyleBackColor = true;
            soggyOption.CheckedChanged += soggyOption_CheckedChanged;
            // 
            // crunchyOption
            // 
            crunchyOption.AutoSize = true;
            crunchyOption.Font = new Font("Ravie", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crunchyOption.Location = new Point(12, 183);
            crunchyOption.Name = "crunchyOption";
            crunchyOption.Size = new Size(176, 38);
            crunchyOption.TabIndex = 10;
            crunchyOption.TabStop = true;
            crunchyOption.Text = "Crunchy";
            crunchyOption.UseVisualStyleBackColor = true;
            crunchyOption.CheckedChanged += crunchyOption_CheckedChanged;
            // 
            // noClickButton
            // 
            noClickButton.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noClickButton.Location = new Point(2, 398);
            noClickButton.Name = "noClickButton";
            noClickButton.Size = new Size(134, 33);
            noClickButton.TabIndex = 11;
            noClickButton.Text = "Don't Click...";
            noClickButton.UseVisualStyleBackColor = true;
            noClickButton.Click += noClickButton_Click;
            // 
            // readOnlyBox
            // 
            readOnlyBox.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            readOnlyBox.Location = new Point(322, 158);
            readOnlyBox.Name = "readOnlyBox";
            readOnlyBox.PlaceholderText = "Result Here";
            readOnlyBox.ReadOnly = true;
            readOnlyBox.Size = new Size(183, 35);
            readOnlyBox.TabIndex = 12;
            readOnlyBox.TextAlign = HorizontalAlignment.Center;
            // 
            // confirmButton
            // 
            confirmButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmButton.Location = new Point(324, 101);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(44, 36);
            confirmButton.TabIndex = 13;
            confirmButton.Text = "+";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // secondNumTextBox
            // 
            secondNumTextBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondNumTextBox.Location = new Point(326, 51);
            secondNumTextBox.Name = "secondNumTextBox";
            secondNumTextBox.PlaceholderText = "Enter a Number";
            secondNumTextBox.Size = new Size(179, 28);
            secondNumTextBox.TabIndex = 14;
            secondNumTextBox.TextAlign = HorizontalAlignment.Center;
            secondNumTextBox.TextChanged += secondNumTextBox_TextChanged;
            // 
            // firstNumTextBox
            // 
            firstNumTextBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNumTextBox.Location = new Point(326, 12);
            firstNumTextBox.Name = "firstNumTextBox";
            firstNumTextBox.PlaceholderText = "Enter a Number";
            firstNumTextBox.Size = new Size(179, 28);
            firstNumTextBox.TabIndex = 15;
            firstNumTextBox.TextAlign = HorizontalAlignment.Center;
            firstNumTextBox.TextChanged += firstNumTextBox_TextChanged;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(326, 220);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(182, 40);
            exitButton.TabIndex = 16;
            exitButton.Text = "Leave";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // subtractionButton
            // 
            subtractionButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subtractionButton.Location = new Point(374, 101);
            subtractionButton.Name = "subtractionButton";
            subtractionButton.Size = new Size(44, 36);
            subtractionButton.TabIndex = 17;
            subtractionButton.Text = "-";
            subtractionButton.UseVisualStyleBackColor = true;
            subtractionButton.Click += subtractionButton_Click;
            // 
            // multiplicationButton
            // 
            multiplicationButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            multiplicationButton.Location = new Point(424, 101);
            multiplicationButton.Name = "multiplicationButton";
            multiplicationButton.Size = new Size(44, 36);
            multiplicationButton.TabIndex = 18;
            multiplicationButton.Text = "x";
            multiplicationButton.UseVisualStyleBackColor = true;
            multiplicationButton.Click += multiplicationButton_Click;
            // 
            // divisionButton
            // 
            divisionButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divisionButton.Location = new Point(474, 101);
            divisionButton.Name = "divisionButton";
            divisionButton.Size = new Size(44, 36);
            divisionButton.TabIndex = 19;
            divisionButton.Text = "/";
            divisionButton.UseVisualStyleBackColor = true;
            divisionButton.Click += divisionButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 432);
            Controls.Add(divisionButton);
            Controls.Add(multiplicationButton);
            Controls.Add(subtractionButton);
            Controls.Add(exitButton);
            Controls.Add(firstNumTextBox);
            Controls.Add(secondNumTextBox);
            Controls.Add(confirmButton);
            Controls.Add(readOnlyBox);
            Controls.Add(noClickButton);
            Controls.Add(crunchyOption);
            Controls.Add(soggyOption);
            Controls.Add(bdayTextBox);
            Controls.Add(bdayLabel);
            Controls.Add(label2);
            Controls.Add(ssnTextBox);
            Controls.Add(ssnLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(clickButton);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Cool Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clickButton;
        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox ssnTextBox;
        private Label ssnLabel;
        private TextBox textBox;
        private Label label2;
        private TextBox bdayTextBox;
        private Label bdayLabel;
        private RadioButton soggyOption;
        private RadioButton crunchyOption;
        private Button noClickButton;
        private TextBox readOnlyBox;
        private Button confirmButton;
        private TextBox secondNumTextBox;
        private TextBox firstNumTextBox;
        private Button exitButton;
        private Button subtractionButton;
        private Button multiplicationButton;
        private Button divisionButton;
    }
}
