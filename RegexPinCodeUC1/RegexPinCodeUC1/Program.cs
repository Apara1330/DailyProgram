using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexPinCodeUC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Three consequative characters");
            ValidatingRegex.ThreeConseqCharacter();
            Console.WriteLine();
            Console.WriteLine("PinCode Samples");
            ValidatingRegex.ValidatePinCodePattern();   
            Console.ReadLine(); 
        }
    }
}
