// See https://aka.ms/new-console-template for more information



using Wordle;



int guessCount = 0;
int guessLimit = 4;
bool outOfGuesses = false;
bool hasGuessedCorrectly = false;

var controller = new WordleController();
var wordOfTheDay = controller._wordOfTheDay;
Console.WriteLine("Your word of the day is " + wordOfTheDay);



while (outOfGuesses == false && hasGuessedCorrectly == false)
{
    Console.Write("Enter a word: ");
    var guessWord = Console.ReadLine();

    var isAWord = controller.IsAWord(guessWord);
    Console.WriteLine("You have guessed " + guessWord);



    if (isAWord == false)
    {
        Console.WriteLine("That is not a valid word");
    }
    else
    {
        guessCount++;
        outOfGuesses = (guessCount >= guessLimit);

    }



    if (controller.IsGuessEqualToWordOfTheDay(guessWord, wordOfTheDay))
    {
        Console.WriteLine("Winner Winner Chicken Dinner!!");
        hasGuessedCorrectly = true;
    }
    else
    {
        Console.WriteLine("You have " + (guessLimit - guessCount) + " guesses remaining!");
    }

}


if (hasGuessedCorrectly == false)
{

    Console.Write("Game over, out of guesses, the word of the day was " + wordOfTheDay);

}

Console.ReadLine();