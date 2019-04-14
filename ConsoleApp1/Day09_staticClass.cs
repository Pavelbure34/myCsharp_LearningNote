using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /* We have gone through the very concept of static in variables and methods.
     * You can also label class as static. When class is static, it has one and only 
     * attribute. You cannot instantiate an object due to static's very attribute but
     * can use it anywhere without instantiating. Let's go over static classes and its
     * properties.
     */
    class Day09_staticClass
    {
        public static void staticClasses()
        {
            //1. Math class
            Console.WriteLine(Math.PI); //prints out PI 3.14
            Console.WriteLine(Math.E);  //natural log with base of e
            Console.WriteLine(Math.Max(14,17));  //get the bigger number
            Console.WriteLine(Math.Min(14,17)); //get the smaller number
            Console.WriteLine(Math.Abs(-4.56)); //get the absiolute value of number
            Console.WriteLine(Math.Cos(45)); //get the cosine of angle..
            Console.WriteLine(Math.Sin(45)); //you can get all the trigonometric values..
            Console.WriteLine(Math.Tan(45));
            Console.WriteLine(Math.Acos(45));
            Console.WriteLine(Math.Pow(2,3));  //get the 2 power of 3 so 8.
            Console.WriteLine(Math.Round(3.6)); //it rounds to nearest double number
            Console.WriteLine(Math.Sqrt(4)); //it gets square root of number.

            //2.Array Class
            int[] arr = { 1, 2, 3 };
            Array.Reverse(arr);  //it reverse the arr
            Console.WriteLine(arr);
            Array.Sort(arr);  //it sorts arr from small to big element.
            Console.WriteLine(arr);

            //3.String class
            string str1 = "Mickey";
            string str2 = "Cohen";
            Console.WriteLine(String.Concat(str1, str2));  //annex both string together
            Console.WriteLine(str1.Equals(str2));    //checks whether two string is the same

            //4. DateTime
            Console.WriteLine(DateTime.Now);  //gets current data and time
            Console.WriteLine(DateTime.Today); //get today's day
            Console.WriteLine(DateTime.DaysInMonth(2016,2)); //get the number of days in specific month/
        }
    }
}
