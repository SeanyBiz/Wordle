namespace Wordle
{
    public class WordProvider
    {
        public List<string> GetWords()
        {

            List<string> allLinesText = File.ReadAllLines(@"C:\Users\eksea\source\repos\Wordle\Wordle\WordList.txt").ToList();


            return FilterWords(allLinesText.ToArray());
        }

        public List<string> FilterWords(string[] words)
        {
            List<string> allFiveLetterWords = new List<string>();
            foreach (string word in words)
            {

                if (word.Length == 5)
                {
                    allFiveLetterWords.Add(word);
                }
            }




            return allFiveLetterWords;
        }
    }
}
