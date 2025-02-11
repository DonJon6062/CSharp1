namespace semiFunctional
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
            numOne = new TextBox();
            numTwo = new TextBox();
            addButton = new Button();
            subtractButton = new Button();
            resultText = new TextBox();
            divideButton = new Button();
            multiplyButton = new Button();
            calculationSelector = new ComboBox();
            selectionLabel = new Label();
            temperatureType = new ComboBox();
            convertTemp = new Button();
            SuspendLayout();
            // 
            // numOne
            // 
            numOne.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold);
            numOne.Location = new Point(268, 116);
            numOne.Name = "numOne";
            numOne.PlaceholderText = "Enter a Number";
            numOne.Size = new Size(257, 31);
            numOne.TabIndex = 0;
            numOne.TextAlign = HorizontalAlignment.Center;
            // 
            // numTwo
            // 
            numTwo.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold);
            numTwo.Location = new Point(268, 176);
            numTwo.Name = "numTwo";
            numTwo.PlaceholderText = "Enter a Number";
            numTwo.Size = new Size(257, 31);
            numTwo.TabIndex = 1;
            numTwo.TextAlign = HorizontalAlignment.Center;
            // 
            // addButton
            // 
            addButton.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold);
            addButton.Location = new Point(268, 231);
            addButton.Name = "addButton";
            addButton.Size = new Size(38, 34);
            addButton.TabIndex = 2;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold);
            subtractButton.Location = new Point(342, 231);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(36, 34);
            subtractButton.TabIndex = 3;
            subtractButton.Text = "-";
            subtractButton.UseVisualStyleBackColor = true;
            subtractButton.Click += subtractButton_Click;
            // 
            // resultText
            // 
            resultText.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold);
            resultText.Location = new Point(323, 306);
            resultText.Name = "resultText";
            resultText.PlaceholderText = "Result";
            resultText.ReadOnly = true;
            resultText.Size = new Size(139, 31);
            resultText.TabIndex = 6;
            resultText.TextAlign = HorizontalAlignment.Center;
            // 
            // divideButton
            // 
            divideButton.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold);
            divideButton.Location = new Point(489, 231);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(36, 34);
            divideButton.TabIndex = 8;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold);
            multiplyButton.Location = new Point(414, 231);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(38, 34);
            multiplyButton.TabIndex = 7;
            multiplyButton.Text = "x";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // calculationSelector
            // 
            calculationSelector.Font = new Font("Cascadia Mono", 10F);
            calculationSelector.FormattingEnabled = true;
            calculationSelector.Location = new Point(242, 62);
            calculationSelector.Name = "calculationSelector";
            calculationSelector.Size = new Size(300, 35);
            calculationSelector.TabIndex = 9;
            calculationSelector.SelectedIndexChanged += calculationSelector_SelectedIndexChanged;
            // 
            // selectionLabel
            // 
            selectionLabel.AutoSize = true;
            selectionLabel.Font = new Font("Cascadia Mono", 10F);
            selectionLabel.Location = new Point(342, 21);
            selectionLabel.Name = "selectionLabel";
            selectionLabel.Size = new Size(120, 27);
            selectionLabel.TabIndex = 10;
            selectionLabel.Text = "Your Epic";
            // 
            // temperatureType
            // 
            temperatureType.Font = new Font("Cascadia Mono", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            temperatureType.FormattingEnabled = true;
            temperatureType.Location = new Point(207, 172);
            temperatureType.Name = "temperatureType";
            temperatureType.Size = new Size(373, 35);
            temperatureType.TabIndex = 11;
            temperatureType.Visible = false;
            // 
            // convertTemp
            // 
            convertTemp.Font = new Font("Cascadia Mono", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            convertTemp.Location = new Point(268, 231);
            convertTemp.Name = "convertTemp";
            convertTemp.Size = new Size(257, 38);
            convertTemp.TabIndex = 12;
            convertTemp.Text = "Convert";
            convertTemp.UseVisualStyleBackColor = true;
            convertTemp.Visible = false;
            convertTemp.Click += convertTemp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(convertTemp);
            Controls.Add(temperatureType);
            Controls.Add(selectionLabel);
            Controls.Add(calculationSelector);
            Controls.Add(divideButton);
            Controls.Add(multiplyButton);
            Controls.Add(resultText);
            Controls.Add(subtractButton);
            Controls.Add(addButton);
            Controls.Add(numTwo);
            Controls.Add(numOne);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numOne;
        private TextBox numTwo;
        private Button addButton;
        private Button subtractButton;
        private TextBox resultText;
        private Button divideButton;
        private Button multiplyButton;
        private ComboBox calculationSelector;
        private Label selectionLabel;
        private ComboBox temperatureType;
        private Button convertTemp;
    }
}
