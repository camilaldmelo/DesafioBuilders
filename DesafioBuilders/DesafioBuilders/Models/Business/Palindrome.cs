using DesafioBuilders.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBuilders.Models.Business
{
    public class Palindrome : IPalindrome
    {
        public string Value { get; set; }
        public string ValueReverse { get; set; }

        public bool CheckPalindrome(string value)
        {
            var retorno = false;
            if (!string.IsNullOrEmpty(value))
            {

                char[] array = value.ToCharArray();
                Array.Reverse(array);
                var valueReverse = new string(array);

                if (value.ToUpper().Equals(valueReverse.ToUpper()))
                {
                    retorno = true;
                }

            }
            return retorno;
        }
    }
}
