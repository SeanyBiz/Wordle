namespace Wordle
{
    public class WordleController
    {

        List<string> _allWords;

        public WordleController()
        {
            System.Console.WriteLine("Creating controller...");
            var wordProvider = new WordProvider();
            _allWords = wordProvider.GetWords();
            System.Console.WriteLine("Finished Creating controller...");
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


    }
}
