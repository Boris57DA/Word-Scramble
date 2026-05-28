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
            this.labelWordScramble = new System.Windows.Forms.Label();
            this.labelAttempts = new System.Windows.Forms.Label();
            this.labelAttemptsCount = new System.Windows.Forms.Label();
            this.labelGuessedWords = new System.Windows.Forms.Label();
            this.labelGuessedWordsValue = new System.Windows.Forms.Label();
            this.labelScrambledWord = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.labelFailedAttempts = new System.Windows.Forms.Label();
            this.textBoxFailedAttempts = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelWordScramble
            // 
            this.labelWordScramble.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWordScramble.AutoSize = true;
            this.labelWordScramble.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWordScramble.Location = new System.Drawing.Point(110, 30);
            this.labelWordScramble.Name = "labelWordScramble";
            this.labelWordScramble.Size = new System.Drawing.Size(237, 38);
            this.labelWordScramble.TabIndex = 0;
            this.labelWordScramble.Text = "Word Scramble";
            // 
            // labelAttempts
            // 
            this.labelAttempts.AutoSize = true;
            this.labelAttempts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAttempts.Location = new System.Drawing.Point(50, 100);
            this.labelAttempts.Name = "labelAttempts";
            this.labelAttempts.Size = new System.Drawing.Size(77, 21);
            this.labelAttempts.TabIndex = 0;
            this.labelAttempts.Text = "Attempts:";
            // 
            // labelAttemptsCount
            // 
            this.labelAttemptsCount.AutoSize = true;
            this.labelAttemptsCount.BackColor = System.Drawing.Color.CadetBlue;
            this.labelAttemptsCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAttemptsCount.ForeColor = System.Drawing.Color.White;
            this.labelAttemptsCount.Location = new System.Drawing.Point(135, 100);
            this.labelAttemptsCount.Name = "labelAttemptsCount";
            this.labelAttemptsCount.Size = new System.Drawing.Size(24, 21);
            this.labelAttemptsCount.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelAttemptsCount.TabIndex = 0;
            this.labelAttemptsCount.Text = "0";
            // 
            // labelGuessedWords
            // 
            this.labelGuessedWords.AutoSize = true;
            this.labelGuessedWords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGuessedWords.Location = new System.Drawing.Point(230, 100);
            this.labelGuessedWords.Name = "labelGuessedWords";
            this.labelGuessedWords.Size = new System.Drawing.Size(117, 21);
            this.labelGuessedWords.TabIndex = 0;
            this.labelGuessedWords.Text = "Guessed words:";
            // 
            // labelGuessedWordsValue
            // 
            this.labelGuessedWordsValue.AutoSize = true;
            this.labelGuessedWordsValue.BackColor = System.Drawing.Color.CadetBlue;
            this.labelGuessedWordsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGuessedWordsValue.ForeColor = System.Drawing.Color.White;
            this.labelGuessedWordsValue.Location = new System.Drawing.Point(355, 100);
            this.labelGuessedWordsValue.Name = "labelGuessedWordsValue";
            this.labelGuessedWordsValue.Size = new System.Drawing.Size(24, 21);
            this.labelGuessedWordsValue.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelGuessedWordsValue.TabIndex = 0;
            this.labelGuessedWordsValue.Text = "0";
            // 
            // labelScrambledWord
            // 
            this.labelScrambledWord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelScrambledWord.AutoSize = true;
            this.labelScrambledWord.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelScrambledWord.Location = new System.Drawing.Point(160, 160);
            this.labelScrambledWord.Name = "labelScrambledWord";
            this.labelScrambledWord.Size = new System.Drawing.Size(161, 27);
            this.labelScrambledWord.TabIndex = 0;
            this.labelScrambledWord.Text = "scrambled word";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInput.Location = new System.Drawing.Point(65, 200);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(130, 32);
            this.textBoxInput.TabIndex = 1;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCheck.ForeColor = System.Drawing.Color.White;
            this.buttonCheck.Location = new System.Drawing.Point(205, 200);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(85, 33);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.ButtonCheckClick);
            // 
            // buttonSkip
            // 
            this.buttonSkip.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSkip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSkip.ForeColor = System.Drawing.Color.White;
            this.buttonSkip.Location = new System.Drawing.Point(300, 200);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(85, 33);
            this.buttonSkip.TabIndex = 4;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = false;
            this.buttonSkip.Click += new System.EventHandler(this.ButtonSkipClick);
            // 
            // labelFailedAttempts
            // 
            this.labelFailedAttempts.AutoSize = true;
            this.labelFailedAttempts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFailedAttempts.Location = new System.Drawing.Point(160, 260);
            this.labelFailedAttempts.Name = "labelFailedAttempts";
            this.labelFailedAttempts.Size = new System.Drawing.Size(120, 21);
            this.labelFailedAttempts.TabIndex = 0;
            this.labelFailedAttempts.Text = "Failed attempts:";
            // 
            // textBoxFailedAttempts
            // 
            this.textBoxFailedAttempts.BackColor = System.Drawing.Color.Silver;
            this.textBoxFailedAttempts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFailedAttempts.Location = new System.Drawing.Point(50, 290);
            this.textBoxFailedAttempts.Multiline = true;
            this.textBoxFailedAttempts.Name = "textBoxFailedAttempts";
            this.textBoxFailedAttempts.ReadOnly = true;
            this.textBoxFailedAttempts.Size = new System.Drawing.Size(350, 60);
            this.textBoxFailedAttempts.TabIndex = 2;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.MinimumSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.textBoxFailedAttempts);
            this.Controls.Add(this.labelFailedAttempts);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelScrambledWord);
            this.Controls.Add(this.labelGuessedWordsValue);
            this.Controls.Add(this.labelGuessedWords);
            this.Controls.Add(this.labelAttemptsCount);
            this.Controls.Add(this.labelAttempts);
            this.Controls.Add(this.labelWordScramble);
            this.Name = "IndexForm";
            this.Text = "Word Scramble";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}