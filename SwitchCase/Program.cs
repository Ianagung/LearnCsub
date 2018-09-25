using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput, outString;

            Console.WriteLine("Enter a string - ");
            userInput = Console.ReadLine();
            Console.WriteLine("You entered {0}", userInput);
            outString = SwitchCase.DoSwitchNormal(userInput);
            Console.WriteLine("Output string is {0}", outString);
            outString = SwitchCase.DoSwitchContains(userInput);
            Console.WriteLine("Output string is {0}", outString);
            outString = SwitchCase.DoSwitchIgnoreCase(userInput);
            Console.WriteLine("Output string is {0}", outString);
            Console.ReadLine();
        }
    }
}
