using System;
using System.Collections.Generic;
using System.IO;
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
            GenerateNewWord();
            UpdateLabels();
        }

        private void GetAllWords()
        {
            using (StreamReader reader = new(wordsTextFile))
            {
                while (!reader.EndOfStream)
                {
                    wordList.Add(reader.ReadLine());
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
                this.labelScrambledWord.Text = "YOU WIN!";
                this.textBoxInput.Enabled = false;
                this.buttonCheck.Enabled = false;
            }
        }

        private void ResetGameInfo()
        {
            attempts = 0;
            failedAttempts.Clear();

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

        private void CheckTheWord()
        {
            string input = this.textBoxInput.Text.Trim();

            if (string.Equals(currentWord, input, StringComparison.OrdinalIgnoreCase))
            {
                guessedWords++;
                this.labelGuessedWordsValue.Text = guessedWords.ToString();

                wordList.Remove(currentWord);
                GenerateNewWord();
            }
            else if (!string.IsNullOrEmpty(input))
            {
                attempts++;
                failedAttempts.Add(input);

                if (attempts > 9)
                {
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
    }
}