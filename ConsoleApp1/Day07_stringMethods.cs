using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /* string is the most frequently used class in any programming language.
     * Here are string related methods that allows programmers to manipulate
     * strins.
     */
    class Day07_stringMethods
    {
        static string String = "Monster";
        
        static void StrMethods()
        {
            //returns the length of string.
            Console.WriteLine(String.Length);
            Console.WriteLine("------------");

            //returns the index of the character in the string.
            Console.WriteLine(String.IndexOf("M"));
            Console.WriteLine("------------");

            //inserts the new string in the previous string in the given index.
            String = String.Insert(0, "He is");
            Console.WriteLine(String);
            Console.WriteLine("------------");

            //replace the matching type with new string in the given string.
            String = String.Replace("He is", "You are");
            Console.WriteLine(String);
            Console.WriteLine("------------");

            //returns boolean value after checking certain characters in string,
            Console.WriteLine(String.Contains("You"));
            Console.WriteLine("------------");

            //removes certain characters in string.
            String = String.Remove(0);
            Console.WriteLine(String);
            Console.WriteLine("------------");

            //get the partial string from the previous string,
            Console.WriteLine(String.Substring(2)); // from given range til the end.
            Console.WriteLine(String.Substring(0, 4)); //given range
            Console.WriteLine("------------");
        }

    }
}
