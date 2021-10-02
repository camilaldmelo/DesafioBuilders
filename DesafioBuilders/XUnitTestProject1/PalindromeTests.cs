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
            bool returnSucess = palindrome.CheckPalindromeTest(valueSucess);
            Assert.True(returnSucess);//verifica se resultado esperado é verdadeiro
        }


        [Fact]
        public void Palidrome_Exception()
        {
            string valueException = "teste";
            Assert.Throws<Exception>(() => palindrome.CheckPalindromeTest(valueException));//verifica se método lança exceção
        }

    }
}
