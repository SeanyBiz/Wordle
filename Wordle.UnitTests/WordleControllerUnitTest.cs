using System.Collections.Generic;
using Xunit;

namespace Wordle.UnitTests
{
    public class WordleControllerUnitTest
    {

        [Fact]
        public void WhenIsAWordIsCalledWithAnInvalidWordReturnFalse()
        {
            //setup
            var controller = new WordleController();

            //act
            var actual = controller.IsAWord("Aidenisagimp");

            //assert
            Assert.False(actual);
        }

        [Fact]
        public void WhenIsAWordIsCalledWithAValidWordReturnTrue()
        {
            //setup
            var controller = new WordleController();

            //act
            var actual = controller.IsAWord("water");

            //assert
            Assert.True(actual);
        }


        [Fact]
        public void WhenIsAWordIsCalledWithAValidWordWhichHasCapitalsReturnTrue()
        {
            //setup
            var controller = new WordleController();

            //act
            var actual = controller.IsAWord("WaTeR");

            //assert
            Assert.True(actual);
        }

        [Fact]
        public void WhenIProvideAValidNonFiveLetterWordReturnFalse()
        {
            //setup
            var controller = new WordleController();

            //act
            var actual = controller.IsAWord("spaceship");

            //assert
            Assert.False(actual);
        }
        [Fact]
        public void GetWordOfTheDayShouldReturnAFiveLetterWord()
        {
            //setup
            var controller = new WordleController();
            var words = new List<string>();
            words.Add("crows");


            //act
            var actual = controller.GetWordOfTheDay(words);

            //assert
            Assert.Equal("crows", actual);
        }
        [Fact]
        public void When_IsGuessEqualToWordOfTheDay_Is_Called_With_Matching_Strings_Return_True()
        {
            //setup
            var controller = new WordleController();


            //act
            var actual = controller.IsGuessEqualToWordOfTheDay("crows", "CROws");

            //assert
            Assert.True(actual);
        }
        [Fact]
        public void When_IsGuessEqualToWordOfTheDay_Is_Called_With_NonMatching_Strings_Return_False()
        {
            //setup
            var controller = new WordleController();


            //act
            var actual = controller.IsGuessEqualToWordOfTheDay("crows", "bears");

            //assert
            Assert.False(actual);
        }
    }

}