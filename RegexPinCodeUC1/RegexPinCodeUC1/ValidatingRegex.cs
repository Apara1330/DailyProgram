using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPinCodeUC1
{
        class ValidatingRegex
        {
        private static string pattern;

        public static void ThreeConseqCharacter()
            {
                string[] inputs = { "111", "1aaa", "aa11", "bcc", "1a1aab", "1abb23a", "aaa123ab", "12jdj33", "12jj86859" };
                string pattern = "^[0-9]*[a-zA-Z]{3,}[0-9a-zA-Z]*$";
                IterateOverArray(inputs, pattern);
             }
            
            public static void ValidatePinCodePattern()
        {
            string[] pinCodeInputs = { "418882", "A463273", "785888B", "A64777", "677 78J" };
            string pinCodePattern = "^[0-9]{6}$";
            IterateOverArray(pinCodeInputs, pinCodePattern);
        }

        private static void IterateOverArray(string[] inputs, string pattern)
        {
            foreach (string s in inputs)
            {
                if (Regex.IsMatch(s, pattern))
                {
                    Console.WriteLine("{0} is Invalid", s);
                }
                else
                {
                    Console.WriteLine("{0} is Valid", s);
                }
            }

        }
    }
    }
