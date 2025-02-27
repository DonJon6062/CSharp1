namespace PunchEm
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
            playerActions = new ComboBox();
            moveDescriptions = new Label();
            roundCounter = new Label();
            Dummy = new Button();
            dummyAction = new Label();
            test = new Button();
            SuspendLayout();
            // 
            // playerActions
            // 
            playerActions.DropDownStyle = ComboBoxStyle.DropDownList;
            playerActions.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            playerActions.FormattingEnabled = true;
            playerActions.Location = new Point(12, 340);
            playerActions.Name = "playerActions";
            playerActions.Size = new Size(290, 37);
            playerActions.TabIndex = 1;
            playerActions.SelectedIndexChanged += playerActions_SelectedIndexChanged;
            // 
            // moveDescriptions
            // 
            moveDescriptions.AutoSize = true;
            moveDescriptions.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            moveDescriptions.Location = new Point(12, 380);
            moveDescriptions.Name = "moveDescriptions";
            moveDescriptions.Size = new Size(195, 29);
            moveDescriptions.TabIndex = 2;
            moveDescriptions.Text = "Attack Description";
            // 
            // roundCounter
            // 
            roundCounter.AutoSize = true;
            roundCounter.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            roundCounter.Location = new Point(345, 19);
            roundCounter.Name = "roundCounter";
            roundCounter.Size = new Size(90, 29);
            roundCounter.TabIndex = 3;
            roundCounter.Text = "Round 1";
            // 
            // Dummy
            // 
            Dummy.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            Dummy.Location = new Point(516, 81);
            Dummy.Name = "Dummy";
            Dummy.Size = new Size(118, 34);
            Dummy.TabIndex = 4;
            Dummy.Tag = "dummyUI";
            Dummy.Text = "Dummy";
            Dummy.UseVisualStyleBackColor = true;
            Dummy.Click += Dummy_Click;
            // 
            // dummyAction
            // 
            dummyAction.AutoSize = true;
            dummyAction.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            dummyAction.Location = new Point(585, 120);
            dummyAction.Name = "dummyAction";
            dummyAction.Size = new Size(49, 29);
            dummyAction.TabIndex = 6;
            dummyAction.Tag = "dummyUI";
            dummyAction.Text = "Null";
            // 
            // test
            // 
            test.Location = new Point(516, 344);
            test.Name = "test";
            test.Size = new Size(118, 33);
            test.TabIndex = 7;
            test.Text = "test";
            test.UseVisualStyleBackColor = true;
            test.Click += test_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(test);
            Controls.Add(dummyAction);
            Controls.Add(Dummy);
            Controls.Add(roundCounter);
            Controls.Add(moveDescriptions);
            Controls.Add(playerActions);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox playerActions;
        private Label moveDescriptions;
        private Label roundCounter;
        private Button Dummy;
        private Label dummyAction;
        private Button test;
    }
}
