// See https://aka.ms/new-console-template for more information

using Wordle;

var controller = new WordleController();
var wordOfTheDay = controller._wordOfTheDay;
Console.WriteLine("Your word of the day is " + wordOfTheDay);

while (controller.outOfGuesses == false && controller.hasGuessedCorrectly == false)
{
    Console.Write("Enter a word: ");
    var guessWord = Console.ReadLine();

    controller.MakeAGuess(guessWord);

}

if (controller.hasGuessedCorrectly == false)
{
    Console.Write("Game over, out of guesses, the word of the day was " + wordOfTheDay);
}

Console.ReadLine();