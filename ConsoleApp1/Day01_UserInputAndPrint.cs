using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Day01_UserInputAndPrint
    {
        /* In order to take userInput in C#, you have to use
         * Console.ReadLine() method. 
         *  I. It always return the string object.
         *  II. in order to take otheer data type, you have to convert input.
         *  
         *  Convert.ToInt32(Console.ReadLine()) -> convert input into integer.
         *  Convert.ToDouble(Console.ReadLine()) -> convert input into double
         *  Convert.ToChar(Console.ReadLine())  -> convert input into char
         *  
         *  
         *  For the printing lines,
         *  Console.WriteLine("  ") -> space between each line.
         *  Console.Write("  ") -> no space between each string.
         */
         public void InputExample()
        {
            Console.Write("Please Write a Integer");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Do not use writeLine when using Convert");
            string name = Console.ReadLine(); //name input.

        }
    }
}
