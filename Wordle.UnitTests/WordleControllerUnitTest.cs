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

        [Fact]
        public void When_MakeAGuess_Is_Called_With_A_Valid_Word_We_Should_Increment_GuessCount()
        {
            //setup
            var controller = new WordleController();
            controller._wordOfTheDay = "shark";
            var guessCountBeforeAct = controller.guessCount;

            //act
            controller.MakeAGuess("belly");

            //assert
            Assert.Equal(guessCountBeforeAct + 1, controller.guessCount);
        }

        [Fact]
        public void When_MakeAGuess_Is_Called_With_A_Invalid_Word_We_Should_Not_Increment_GuessCount()
        {
            //setup
            var controller = new WordleController();
            controller._wordOfTheDay = "shark";
            var guessCountBeforeAct = controller.guessCount;

            //act
            controller.MakeAGuess("toenails");

            //assert
            Assert.Equal(guessCountBeforeAct, controller.guessCount);
        }

        [Fact]
        public void When_MakeAGuess_Is_Called_With_A_Word_That_Matches_The_Word_Of_The_Day_hasGuessedCorrectly_Should_be_True()
        {
            //setup
            var controller = new WordleController();
            controller._wordOfTheDay = "shark";

            //act
            controller.MakeAGuess("shark");

            //assert
            Assert.True(controller.hasGuessedCorrectly);
        }

        [Fact]
        public void When_MakeAGuess_Is_Called_With_A_Word_That_Does_Not_Match_The_Word_Of_The_Day_hasGuessedCorrectly_Should_be_False()
        {
            //setup
            var controller = new WordleController();
            controller._wordOfTheDay = "shark";

            //act
            controller.MakeAGuess("tripe");

            //assert
            Assert.False(controller.hasGuessedCorrectly);
        }

        [Fact]
        public void When_MakeAGuess_Is_Called_With_1_Guess_Remaining_Ensure_outOfGuesses_is_true()
        {
            //setup
            var controller = new WordleController();
            controller._wordOfTheDay = "shark";
            controller.guessCount = 3;
            controller.guessLimit = 4;

            //act
            controller.MakeAGuess("tripe");

            //assert
            Assert.True(controller.outOfGuesses);
        }

        [Fact]
        public void When_MakeAGuess_Is_Called_With_5_Guess_Remaining_Ensure_outOfGuesses_is_False()
        {
            //setup
            var controller = new WordleController();
            controller._wordOfTheDay = "shark";
            controller.guessCount = 1;
            controller.guessLimit = 6;

            //act
            controller.MakeAGuess("tripe");

            //assert
            Assert.False(controller.outOfGuesses);
        }
    }

}