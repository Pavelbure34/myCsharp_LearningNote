using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class thisAndRO
    {
        //these two are readonly and const strings in member.
        private readonly string str1;
        private readonly int int1;
        private const string str2 = "It has to be reset when creating.";
        private const int int2 = 3;
        private double num1;

        /* There are three big difference between const and readonly.
         * 
         * I. readonly can be reset in constructor while const has to be reset when created.
         * II. while both readonly and cosnt cannot be modified after construction,
         *      readonly can hold value of arithematic output.
         */

        public thisAndRO()
        {
            str1 = "It can be reset by constructor.";
            int1 = 5; //so int2 since it is readonly. 
        }

        public void setDouble()
        {
            //this keyword refers to its object.
            this.num1 = ((int)(Math.PI *  100)/ (double)100); //print out 3.14
        }

        public void LogInfo()
        {
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(int1);
            Console.WriteLine(int2);
            Console.WriteLine(num1);
        }
    }

    class Day10_thisAndreadonly
    {
        public static void copyFunc()
        {
            thisAndRO example = new thisAndRO();
            example.setDouble();
            example.LogInfo();
        }
    }
}
