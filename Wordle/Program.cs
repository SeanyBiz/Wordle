// See https://aka.ms/new-console-template for more information



using Wordle;


var controller = new WordleController();


Console.Write("Enter a word: ");
var guessWord = Console.ReadLine();
var isAWord = controller.IsAWord(guessWord);
Console.WriteLine("You have guessed " + guessWord);

if (isAWord == true)
{
    Console.WriteLine("Well done sir");
}
else
{
    Console.WriteLine("Unlucky!");
}

Console.ReadLine();