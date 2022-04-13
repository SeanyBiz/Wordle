using Xunit;

namespace Wordle.UnitTests
{
    public class WordProviderUnitTest
    {

        [Fact]
        public void WhenFilterWordsIsCalledWeWantOnly5LetterWords()

        {
            //setup
            var wordProvider = new WordProvider();
            var expected = new string[] { "beans", "adore" };

            //act
            var wordsToBeFiltered = new string[] { "beans", "cat", "biscuit", "cabbage", "adore" };
            var actual = wordProvider.FilterWords(wordsToBeFiltered);

            //assert
            Assert.Equal(expected, actual);

        }

    }
}