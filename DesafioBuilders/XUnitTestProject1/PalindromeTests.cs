using DesafioBuilders.Models.Business;
using System;
using Xunit;

namespace DesafioBuilders_Tests
{
    public class PalindromeTests
    {
        private readonly Palindrome palindrome = new Palindrome();

        [Fact]
        public void Palidrome_Sucess()
        {
            string valueSucess = "nattan";
            bool returnSucess = palindrome.CheckPalindrome(valueSucess);
            Assert.True(returnSucess);
        }

        [Fact]
        public void Palidrome_False()
        {
            string valueSucess = "teste";
            bool returnSucess = palindrome.CheckPalindrome(valueSucess);
            Assert.False(returnSucess);
        }
    }
}
