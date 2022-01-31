using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo098
{
     class ValidatingRegex
    {
        public static void ThreeConseqCharacter()
        { 
            string[] inputs = { "111", "1aaa", "aa11", "bcc", "1a1aab", "1abb23a" };
            string pattern = "^[0-9]*[a-zA-Z]{3,}[0-9a-zA-Z]*$";
            
            foreach(string s in inputs)
            {
                if(Regex.IsMatch(s, pattern))
                {
                    Console.WriteLine("{0} is Valid", s);
                }
                else
                {
                    Console.WriteLine("{0} is Invalid", s);
                }
            }

            
        }
        

    }
}
