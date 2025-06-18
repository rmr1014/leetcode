using LeetCode.Core.Easy;
using Xunit;

namespace LeetCode.Core.Tests.Easy
{
    public class PalindromeNumberTests
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [InlineData(0, true)]
        [InlineData(12321, true)]
        [InlineData(123321, true)]
        [InlineData(1001, true)]
        [InlineData(100, false)]
        [InlineData(int.MaxValue, false)]
        [InlineData(int.MinValue, false)]
        public void IsPalindrome_ReturnsExpectedResult(int input, bool expected)
        {
            var palindromeNumber = new PalindromeNumber();

            var result = palindromeNumber.IsPalindrome(input);

            Assert.Equal(expected, result);
        }
    }
}