using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Scramble
{
    public partial class IndexForm : Form
    {
        private const string wordsTextFile = @"../../../words.txt";

        private readonly List<string> failedAttempts = new();
        private readonly List<string> wordList = new();

        private int attempts = 0;
        private int guessedWords = 0;
        private string currentWord = string.Empty;
        private int revealedHintLetters = 0;

        public IndexForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            GetAllWords();
            GenerateNewWord();
        }

        private void ButtonCheckClick(object sender, EventArgs e)
        {
            CheckTheWord();
            UpdateLabels();
        }

        private void ButtonSkipClick(object sender, EventArgs e)
        {
            MessageBox.Show($"Правилната дума беше: {currentWord.ToUpper()}", "Пропусната дума", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GenerateNewWord();
            UpdateLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonHintClick(sender, e);
        }

        private void ButtonHintClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentWord)) return;

            if (revealedHintLetters < currentWord.Length)
            {
                revealedHintLetters++;
            }

            string hintDisplay = "Подсказка: ";

            for (int i = 0; i < currentWord.Length; i++)
            {
                if (i < revealedHintLetters)
                {
                    hintDisplay += currentWord[i].ToString().ToUpper() + " ";
                }
                else
                {
                    hintDisplay += "_ ";
                }
            }

            this.labelHintDisplay.Text = hintDisplay.Trim();
        }

        private void GetAllWords()
        {
            if (!File.Exists(wordsTextFile))
            {
                MessageBox.Show("Файлът words.txt не беше намерен!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (StreamReader reader = new(wordsTextFile))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine()?.Trim();

                    if (!string.IsNullOrEmpty(line) && line.Length == 5)
                    {
                        wordList.Add(line);
                    }
                }
            }
        }

        private void GenerateNewWord()
        {
            Random random = new();

            if (wordList.Count > 0)
            {
                int randomIndex = random.Next(0, wordList.Count);
                currentWord = wordList[randomIndex];

                ResetGameInfo();
            }
            else
            {
                this.labelScrambledWord.Text = "ТИ СПЕЧЕЛИ!";
                this.textBoxInput.Enabled = false;
                this.buttonCheck.Enabled = false;
                this.buttonSkip.Enabled = false;
                this.button1.Enabled = false;
            }
        }

        private void ResetGameInfo()
        {
            attempts = 0;
            failedAttempts.Clear();
            revealedHintLetters = 0;

            if (this.labelHintDisplay != null)
            {
                this.labelHintDisplay.Text = string.Empty;
            }

            this.labelScrambledWord.Text = ScrambleWord(currentWord);
        }

        private static string ScrambleWord(string word)
        {
            char[] chars = word.ToCharArray();
            Random rng = new();
            int n = chars.Length;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                (chars[n], chars[k]) = (chars[k], chars[n]);
            }

            return new string(chars);
        }

        private async void CheckTheWord()
        {
            string input = this.textBoxInput.Text.Trim();

            if (string.Equals(currentWord, input, StringComparison.OrdinalIgnoreCase))
            {

                guessedWords++;
                this.labelGuessedWordsValue.Text = guessedWords.ToString();

                wordList.Remove(currentWord);
                GenerateNewWord();

                System.Drawing.Color originalColor = this.BackColor;
                this.BackColor = System.Drawing.Color.LightGreen;

                await Task.Delay(250);

                this.BackColor = originalColor;
            }
            else if (!string.IsNullOrEmpty(input))
            {
                attempts++;
                failedAttempts.Add(input);

                if (attempts > 9)
                {
                    MessageBox.Show($"Изчерпа всички опити! Правилната дума беше: {currentWord.ToUpper()}", "Край на играта", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    GenerateNewWord();
                }
            }
        }

        private void UpdateLabels()
        {
            this.textBoxFailedAttempts.Text = string.Join(", ", failedAttempts);
            this.labelAttemptsCount.Text = attempts.ToString();
            this.textBoxInput.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
        }
    }
}