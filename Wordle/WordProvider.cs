namespace Wordle
{
    internal class WordProvider
    {
        public List<string> GetWords()
        {

            List<string> allLinesText = File.ReadAllLines(@"C:\Users\eksea\source\repos\Wordle\Wordle\WordList.txt").ToList();


            return allLinesText;
        }
    }
}
