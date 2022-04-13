// See https://aka.ms/new-console-template for more information



using Wordle;

var wordProvider = new WordProvider();
var allWords = wordProvider.GetWords();



Console.Write("Enter a word: ");
var GuessWord = Console.ReadLine();
Console.WriteLine("You have guessed " + GuessWord);
