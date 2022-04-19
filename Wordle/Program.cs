// See https://aka.ms/new-console-template for more information



using Wordle;


var controller = new WordleController();
var wordOfTheDay = controller._wordOfTheDay;
Console.WriteLine("Your word of the day is " + wordOfTheDay);

Console.Write("Enter a word: ");
var guessWord = Console.ReadLine();
var isAWord = controller.IsAWord(guessWord);
Console.WriteLine("You have guessed " + guessWord);

if (isAWord == false)
{
    Console.WriteLine("That is not a valid word");
}

if (controller.IsGuessEqualToWordOfTheDay(guessWord, wordOfTheDay))
{
    Console.WriteLine("Winner Winner Chicken Dinner!!");
}
else
{
    Console.WriteLine("Wrong answer, you failure!");
}

Console.ReadLine();