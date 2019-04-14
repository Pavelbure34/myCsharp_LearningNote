using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /* The error Handling is important since it prevents program from
     * shutting down due to error. Apart of systemic error such as faulty machine,
     * Excpetions can be handled.
     */
    class Day20_ExceptHandling
    {
        
        void CopyMethod()
        {
            //Singular Exception Handling.
            int x;
            while (true)
            {
                try
                {
                    Console.Write("Write a number for integer x >> ");
                    x = Convert.ToInt32(Console.ReadLine());  //this line is possible error spot.
                    break;  //if int is input, break the loop.
                }
                catch (Exception e)
                {   //if input is not integer, the error occurs, then move it to here.
                    Console.WriteLine("You have to write an integer.");
                    continue;
                }
            }
            Console.WriteLine("Integer x is {0}", x);
            Console.Read();
        }

        //Multiple Exception Handling
        void CopyMethod2()
        {
            int x;
            int y;
            int z;
            while (true)
            {
                try
                {
                    Console.Write("Write any number for x >> ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write any number for y >> ");
                    y = Convert.ToInt32(Console.ReadLine());
                    z = x / y;
                    break;
                }
                catch (DivideByZeroException e1)
                {   //this occurs when y equals to zero.
                    Console.WriteLine("You cannot divide by zero.");
                    Console.WriteLine("Please do it again.");
                    continue;
                }
                catch (Exception e2)
                {    //this occurs when either x or y input is not integer.
                    Console.WriteLine("Please Write Integer.");
                    continue;
                }
            }
            Console.WriteLine("Integer z is {0}.", z);
            Console.Read();
        }

        //finally build
        void copyMethod3()
        {
            int num = 0;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e3)
            {
                Console.WriteLine("Please Write Integer");
            }
            finally  //it is optional. it is executed anyway.
            {
                Console.WriteLine("num is {0}.", num);
                Console.WriteLine("This is executed anyway!");
            }
            Console.Read();
        }


        /* You can throw the exception somewhere else by using throw keyword.
         * and make your own exception.
         */

        //we have made a custom exception.
        [Serializable()] //serialization is needed 
        public class HPNegativeException : System.Exception
        {
            public HPNegativeException(): base() { }   //basic default
            public HPNegativeException(string message) : base(message) { }
            public HPNegativeException(string message, System.Exception inner) : base(message, inner) { }
            protected HPNegativeException(System.Runtime.Serialization.SerializationInfo info,
                System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        }
        //this method throws exception when HPNegativeException occurs.
        static void throwExample(int change)
        {
            int HP = 10;
            if ((HP - change) < 0)
                throw new HPNegativeException();  //under the certain condition, it is throwing the exception.
           
            Console.WriteLine("HP : {0}", HP);
        }

        void ThrowCathcer()
        {
            int change;
            while (true)
            {
                try
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    throwExample(change);  //this throw the exception under the certain condition.
                    break;
                }
                catch (HPNegativeException e)  //it is catching the exception thrown and handle it here.
                {
                    Console.WriteLine("HP cannot be negative!");
                    continue;
                }
            }
            Console.Read();
        }

        /* Finally, we are gonna cover exception you will use often.
         * ArithmeticException -> exception happening while arithemetic operator, casting..
         * ArrayTypeMismatchException -> element type and array type mismatch
         * IndexOutOfRangeException -> when index is off the limit
         * InvalidOperationException -> method called is invalid for current state
         * NullReferenceException -> same as NullPointerException
         * DirectoryNotFoundException -> part of file or directory is not found
         * Exception -> mother of all the exception
         */

    }
}
