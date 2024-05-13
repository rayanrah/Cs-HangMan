// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // The secret word
            string secretWord = "Computer";

            // The word as displayed to the player
            string displayWord = new string('_', secretWord.Length);

            // The incorrect guesses
            StringBuilder incorrectGuesses = new StringBuilder();

            // The correct letters
            char[] correctLetters = new char[secretWord.Length];

            // The player has not made any guesses yet
            bool hasMadeGuess = false;

            // Number of guessing attempts
            int guessingAttempts = 0;
            const int maxAttempts = 7;

            // Hangman characters
            string[] hangman = {
                "  ________\n |        |\n |\n |\n |\n |\n_|___",
                "  ________\n |        |\n |        O\n |\n |\n |\n_|___",
                "  ________\n |        |\n |        O\n |        |\n |\n |\n_|___",
                "  ________\n |        |\n |        O\n |       /|\n |\n |\n_|___",
                "  ________\n |        |\n |        O\n |       /|\\\n |\n |\n_|___",
                "  ________\n |        |\n |        O\n |       /|\\\n |       /\n |\n_|___",
                "  ________\n |        |\n |        O\n |       /|\\\n |       / \\\n |\n_|___"
            };

            // The game loop
            while (guessingAttempts < maxAttempts)
            {
                // Display the hangman
                Console.WriteLine(hangman[guessingAttempts]);

                // Display the word
                Console.WriteLine("The word: " + displayWord);

                // Display the incorrect guesses
                Console.WriteLine("Incorrect guesses: " + incorrectGuesses);

                // Display the number of guessing attempts
                Console.WriteLine($"Guessing attempt: {guessingAttempts + 1}/{maxAttempts}");

                // Get the player's guess
                Console.Write("Guess a letter: ");
                string guess = Console.ReadLine();

                // Make sure the guess is only one letter
                if (guess.Length == 1)
                {
                    // Convert the guess to lowercase
                    guess = guess.ToLower();

                    // Check if the player has made this guess before
                    if (!hasMadeGuess)
                    {
                        hasMadeGuess = true;
                    }
                    else if (incorrectGuesses.ToString().Contains(guess))
                    {
                        Console.WriteLine("You already made this guess.");
                        continue;
                    }

                    // Check if the guess is correct
                    if (secretWord.ToLower().Contains(guess))
                    {
                        // Update the display word
                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            if (char.ToLower(secretWord[i]) == guess[0])
                            {
                                displayWord = displayWord.Substring(0, i) + secretWord[i] + displayWord.Substring(i + 1);
                                correctLetters[i] = secretWord[i];
                            }
                        }

                        // Check if the player has won
                        if (displayWord == secretWord)
                        {
                            Console.WriteLine("You won!");
                            break;
                        }
                    }
                    else
                    {
                        // Add the guess to the incorrect guesses
                        if (!incorrectGuesses.ToString().Contains(guess))
                        {
                            incorrectGuesses.Append(guess + " ");
                        }

                        // Increment the guessing attempts
                        guessingAttempts++;
                    }
                }
                else
                {
                    Console.WriteLine("Please guess one letter at a time.");
                }
            }

            // If the player runs out of attempts
            if (guessingAttempts >= maxAttempts)
            {
                Console.WriteLine("You ran out of attempts. The correct word was: " + secretWord);
            }
        }
    }
}
