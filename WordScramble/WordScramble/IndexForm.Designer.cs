namespace Word_Scramble
{
    partial class IndexForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelWordScramble = new Label();
            labelAttempts = new Label();
            labelAttemptsCount = new Label();
            labelGuessedWords = new Label();
            labelGuessedWordsValue = new Label();
            labelScrambledWord = new Label();
            textBoxInput = new TextBox();
            buttonCheck = new Button();
            buttonSkip = new Button();
            labelFailedAttempts = new Label();
            textBoxFailedAttempts = new TextBox();
            button1 = new Button();
            labelHintDisplay = new Label();
            SuspendLayout();
            // 
            // labelWordScramble
            // 
            labelWordScramble.Anchor = AnchorStyles.Top;
            labelWordScramble.AutoSize = true;
            labelWordScramble.Font = new Font("Georgia", 24F, FontStyle.Bold);
            labelWordScramble.Location = new Point(86, 9);
            labelWordScramble.Name = "labelWordScramble";
            labelWordScramble.Size = new Size(344, 46);
            labelWordScramble.TabIndex = 0;
            labelWordScramble.Text = "Word Scramble";
            // 
            // labelAttempts
            // 
            labelAttempts.AutoSize = true;
            labelAttempts.Font = new Font("Segoe UI", 12F);
            labelAttempts.Location = new Point(57, 74);
            labelAttempts.Name = "labelAttempts";
            labelAttempts.Size = new Size(97, 28);
            labelAttempts.TabIndex = 0;
            labelAttempts.Text = "Attempts:";
            // 
            // labelAttemptsCount
            // 
            labelAttemptsCount.AutoSize = true;
            labelAttemptsCount.BackColor = Color.DarkSeaGreen;
            labelAttemptsCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelAttemptsCount.ForeColor = Color.Cornsilk;
            labelAttemptsCount.Location = new Point(154, 74);
            labelAttemptsCount.Name = "labelAttemptsCount";
            labelAttemptsCount.Padding = new Padding(5, 2, 5, 2);
            labelAttemptsCount.Size = new Size(34, 32);
            labelAttemptsCount.TabIndex = 0;
            labelAttemptsCount.Text = "0";
            // 
            // labelGuessedWords
            // 
            labelGuessedWords.AutoSize = true;
            labelGuessedWords.Font = new Font("Segoe UI", 12F);
            labelGuessedWords.Location = new Point(283, 78);
            labelGuessedWords.Name = "labelGuessedWords";
            labelGuessedWords.Size = new Size(147, 28);
            labelGuessedWords.TabIndex = 0;
            labelGuessedWords.Text = "Guessed words:";
            // 
            // labelGuessedWordsValue
            // 
            labelGuessedWordsValue.AutoSize = true;
            labelGuessedWordsValue.BackColor = Color.DarkSeaGreen;
            labelGuessedWordsValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelGuessedWordsValue.ForeColor = Color.Cornsilk;
            labelGuessedWordsValue.Location = new Point(426, 78);
            labelGuessedWordsValue.Name = "labelGuessedWordsValue";
            labelGuessedWordsValue.Padding = new Padding(5, 2, 5, 2);
            labelGuessedWordsValue.Size = new Size(34, 32);
            labelGuessedWordsValue.TabIndex = 0;
            labelGuessedWordsValue.Text = "0";
            // 
            // labelScrambledWord
            // 
            labelScrambledWord.Anchor = AnchorStyles.Top;
            labelScrambledWord.AutoSize = true;
            labelScrambledWord.Font = new Font("Georgia", 18F, FontStyle.Italic);
            labelScrambledWord.Location = new Point(209, 128);
            labelScrambledWord.Name = "labelScrambledWord";
            labelScrambledWord.Size = new Size(104, 35);
            labelScrambledWord.TabIndex = 0;
            labelScrambledWord.Text = "Words";
            // 
            // textBoxInput
            // 
            textBoxInput.BackColor = Color.White;
            textBoxInput.BorderStyle = BorderStyle.FixedSingle;
            textBoxInput.Font = new Font("Segoe UI", 14F);
            textBoxInput.ForeColor = Color.Black;
            textBoxInput.Location = new Point(120, 182);
            textBoxInput.Margin = new Padding(3, 4, 3, 4);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(246, 39);
            textBoxInput.TabIndex = 1;
            textBoxInput.TextAlign = HorizontalAlignment.Center;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // buttonCheck
            // 
            buttonCheck.BackColor = Color.DarkSeaGreen;
            buttonCheck.Cursor = Cursors.Hand;
            buttonCheck.FlatAppearance.BorderSize = 0;
            buttonCheck.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            buttonCheck.FlatStyle = FlatStyle.Flat;
            buttonCheck.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonCheck.ForeColor = Color.Cornsilk;
            buttonCheck.Location = new Point(86, 242);
            buttonCheck.Margin = new Padding(3, 4, 3, 4);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(105, 44);
            buttonCheck.TabIndex = 3;
            buttonCheck.Text = "Check";
            buttonCheck.UseVisualStyleBackColor = false;
            buttonCheck.Click += ButtonCheckClick;
            // 
            // buttonSkip
            // 
            buttonSkip.BackColor = Color.FromArgb(230, 115, 115);
            buttonSkip.Cursor = Cursors.Hand;
            buttonSkip.FlatAppearance.BorderSize = 0;
            buttonSkip.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            buttonSkip.FlatStyle = FlatStyle.Flat;
            buttonSkip.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSkip.ForeColor = SystemColors.Window;
            buttonSkip.Location = new Point(197, 242);
            buttonSkip.Margin = new Padding(3, 4, 3, 4);
            buttonSkip.Name = "buttonSkip";
            buttonSkip.Size = new Size(97, 44);
            buttonSkip.TabIndex = 4;
            buttonSkip.Text = "Skip";
            buttonSkip.UseVisualStyleBackColor = false;
            buttonSkip.Click += ButtonSkipClick;
            // 
            // labelFailedAttempts
            // 
            labelFailedAttempts.AutoSize = true;
            labelFailedAttempts.Font = new Font("Segoe UI", 12F);
            labelFailedAttempts.Location = new Point(183, 347);
            labelFailedAttempts.Name = "labelFailedAttempts";
            labelFailedAttempts.Size = new Size(150, 28);
            labelFailedAttempts.TabIndex = 0;
            labelFailedAttempts.Text = "Failed attempts:";
            // 
            // textBoxFailedAttempts
            // 
            textBoxFailedAttempts.BackColor = Color.FromArgb(245, 235, 215);
            textBoxFailedAttempts.BorderStyle = BorderStyle.None;
            textBoxFailedAttempts.Font = new Font("Segoe UI", 12F);
            textBoxFailedAttempts.ForeColor = Color.DimGray;
            textBoxFailedAttempts.Location = new Point(57, 387);
            textBoxFailedAttempts.Margin = new Padding(3, 4, 3, 4);
            textBoxFailedAttempts.Multiline = true;
            textBoxFailedAttempts.Name = "textBoxFailedAttempts";
            textBoxFailedAttempts.ReadOnly = true;
            textBoxFailedAttempts.Size = new Size(399, 79);
            textBoxFailedAttempts.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Azure;
            button1.Location = new Point(300, 242);
            button1.Name = "button1";
            button1.Size = new Size(113, 45);
            button1.TabIndex = 5;
            button1.Text = "Hint";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelHintDisplay
            // 
            labelHintDisplay.AutoSize = true;
            labelHintDisplay.Location = new Point(183, 303);
            labelHintDisplay.Name = "labelHintDisplay";
            labelHintDisplay.Size = new Size(50, 20);
            labelHintDisplay.TabIndex = 6;
            labelHintDisplay.Text = "label1";
            labelHintDisplay.Click += label1_Click;
            // 
            // IndexForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(494, 512);
            Controls.Add(labelHintDisplay);
            Controls.Add(button1);
            Controls.Add(textBoxFailedAttempts);
            Controls.Add(labelFailedAttempts);
            Controls.Add(buttonSkip);
            Controls.Add(buttonCheck);
            Controls.Add(textBoxInput);
            Controls.Add(labelScrambledWord);
            Controls.Add(labelGuessedWordsValue);
            Controls.Add(labelGuessedWords);
            Controls.Add(labelAttemptsCount);
            Controls.Add(labelAttempts);
            Controls.Add(labelWordScramble);
            ForeColor = SystemColors.Desktop;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(512, 518);
            Name = "IndexForm";
            Text = "Word Scramble";
            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelWordScramble;
        private System.Windows.Forms.Label labelAttempts;
        private System.Windows.Forms.Label labelAttemptsCount;
        private System.Windows.Forms.Label labelGuessedWords;
        private System.Windows.Forms.Label labelGuessedWordsValue;
        private System.Windows.Forms.Label labelScrambledWord;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.Label labelFailedAttempts;
        private System.Windows.Forms.TextBox textBoxFailedAttempts;
        private Button button1;
        private Label labelHintDisplay;
    }
}