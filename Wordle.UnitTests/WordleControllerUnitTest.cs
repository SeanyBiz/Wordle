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

    }

}