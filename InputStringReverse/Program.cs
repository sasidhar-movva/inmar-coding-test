using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputStringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine().ToCharArray();
            var stringLength = inputString.Length; 

            for (int i = 0; i < stringLength / 2; i++)
            {
                var tempChar = inputString[i];
                inputString[i] = inputString[stringLength - 1 - i];
                inputString[stringLength - 1 - i] = tempChar;
            }
            Console.WriteLine(new string(inputString));
            Console.ReadLine();
        }
    }
}
