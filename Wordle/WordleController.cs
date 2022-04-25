namespace Wordle
{
    public class WordleController
    {

        List<string> _allWords;
        public string _wordOfTheDay;

        public int guessCount = 0;
        public int guessLimit = 4;
        public bool outOfGuesses = false;
        public bool hasGuessedCorrectly = false;


        public WordleController()
        {
            System.Console.WriteLine("Creating controller...");
            var wordProvider = new WordProvider();
            _allWords = wordProvider.GetWords();
            _wordOfTheDay = GetWordOfTheDay(_allWords);
            System.Console.WriteLine("Finished Creating controller...");
        }

        public string GetWordOfTheDay(List<string> allWords)
        {
            Random r = new Random();
            int index = r.Next(allWords.Count);
            string randomString = allWords[index];
            return randomString;
        }

        public bool IsAWord(string wordToBeValidated)
        {

            foreach (string word in _allWords)
            {
                if (word.ToLower() == wordToBeValidated.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public void MakeAGuess(string guessWord)
        {
            var isAWord = IsAWord(guessWord);
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


            if (IsGuessEqualToWordOfTheDay(guessWord, _wordOfTheDay))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!!");
                hasGuessedCorrectly = true;
            }
            else
            {
                Console.WriteLine("You have " + (guessLimit - guessCount) + " guesses remaining!");
            }

        }

        public bool IsGuessEqualToWordOfTheDay(string guess, string wordOfTheDay)
        {
            return (guess.ToLower() == wordOfTheDay.ToLower());
        }
    }
}
