namespace Wordle
{
    public class WordleController
    {

        List<string> _allWords;
        public readonly string _wordOfTheDay;


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

        public bool IsGuessEqualToWordOfTheDay(string guess, string wordOfTheDay)
        {
            return (guess.ToLower() == wordOfTheDay.ToLower());
        }
    }
}
