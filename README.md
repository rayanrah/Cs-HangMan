Hangman Game:
Your assignment is to create a game called Hangman. The hangman game is a pen-and-pencil guessing game for two or more players.
You can read more about it https://en.wikipedia.org/wiki/Hangman_(game). One player (in our case the application) thinks of a word and the other player(s) tries to guess it by suggesting letters. The word to guess is represented by a row of dashes where each dash represents a letter in the word.

-- Game Rules to implement:

•The player has 10 guesses to complete the word before losing the game.

•The player can make two types of guesses:
  oGuess for a specific letter. If the player guesses a letter that occurs in the word, the program should update by inserting the letter in the correct position(s).
  oGuess for the whole word. The player type in a word he/she thinks is the word.If the guess is correct player wins the game and the whole word is revealed. If the word is incorrect nothing should get revealed.

•If the player guesses the same letter twice, the program will not consume a guess.

-- Code Requirements:

•The secret word should be randomly chosen from an array of Strings.

•The incorrect letters the player has guessed, should be put inside a StringBuilder and presented to the player after each guess.

•The correct letters should be put inside a char array. Unrevealed letters need to be represented by a lower dash ( _ ).
