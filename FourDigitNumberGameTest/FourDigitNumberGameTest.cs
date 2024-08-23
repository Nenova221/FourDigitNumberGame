using Xunit;
using FourDigitNumberGame;
namespace FourDigitNumberGameTest

{
    public class FourDigitNumberGameTest
    {
        [Theory]
        [InlineData(5129, 17)]
        [InlineData(1234, 10)]
        [InlineData(2222, 8)]
        public void SumOfDigits_WithFourDigits_ShouldReturnCorrectSum(int number, int expectedSum)
        {
            int result = SumOfDigits.FourDigitNumberGame(number, expectedSum);
            Assert.Equal(expectedSum, result);
        }
        [Theory]
        [InlineData(1598, "8951")]
        [InlineData(1234, "4321")]
        [InlineData(9221, "1229")]
        public void SumOfDigits_WithFourDigits_ShouldReturnReverseOrder(int number, string expectedSum)
        {
            string result = FourDigitNumberGame.SumOfDigits(number, expectedSum);
            Assert.Equal(expectedSum, result);
        }
        [Theory]
        [InlineData(2011, "1201")]
        [InlineData(1234, "4123")]
        [InlineData(9221, "1922")]
        public void SumOfDigits_WithFourDigits_ShouldPlaceLastDigitFirst(int number, string expectedSum)
        {
            string result = FourDigitNumberGame.SumOfDigits(number, expectedSum);
            Assert.Equal(expectedSum, result);
        }
        [Theory]
        [InlineData(8624, "8264")]
        [InlineData(1234, "1324")]
        [InlineData(4039, "4309")]
        public void SumOfDigits_WithFourDigits_ShouldPlaceSecondDigitThird(int number, string expectedSum)
        {
            string result = FourDigitNumberGame.SumOfDigits(number, expectedSum);
            Assert.Equal(expectedSum, result);
        }
    }
}