using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Destr_Static
    {
        /* Today, we are gonna go over static keyword. 
         * first we are gonna set up two integer member varibles.
         * The first one is regular private one and the other is static private.
         */
        private int x = 0;
        private static int y = 5;

        public Destr_Static() { }
        //this is constructor. It is called only once when an object is
        //instantiated from the class.

        ~Destr_Static() { }
        //this is destructor. It is only called once when object is deleted.
        //the object is deleted when program or the block where it belongs to ends.
        //Unlike C++ destructor, C# destructor has some different characteristics
        //It cannot be called manualy. it is called automatically.
        //it does not take any parameter.

        //methods
        public void setInt()
        {  //using this method, we are gonna increment both x and y.
            x++;
            y++;
        }

        public void getInt()
        { //using this method, we are gonna check whether x and y increments
           //separately for each object.
            Console.WriteLine("x = {0} and y = {1}",x, y);
        }
    }

    /* Based on the result, integer x is separate for each object but
     * static integer y stays alone no matter how many objects are created
     * based on the corresponding class.
     */

    class Static_Exp
    {
        //static member variables
        private static string message;
        private static int var1;
        private static double var2;
        private static char var3;

        //constructor
        public Static_Exp() { }

        //Static Initializer reset the static member variables.
        //it is automatically called once when accessing static members.
        static Static_Exp()
        {
            message = "This is static initializer.";
            var1 = 1;
            var2 = 2.0;
            var3 = 'd';
            Console.WriteLine(message);
        }
    }

    class Day08_destructorAndstatic
    {
        public void CopyMethod()
        {
            Destr_Static example1 = new Destr_Static();
            Destr_Static example2 = new Destr_Static();
            example1.setInt(); //this increment both x and y  y = 6
            example2.setInt(); //y has been incremented twice. y = 7
            example1.getInt(); //it shows x = 1 and y =7.
            example2.getInt(); //it shows x = 1 and y  = 7.
            Console.Read();
        }

        public void CopyMethod2()
        {
            Static_Exp example1 = new Static_Exp();
            //this will printout the messsage embedded in static initializer
            //when it is called.
        }

        static int staticInt = 5;
        //this is static variable. You can use it anywhere due to its global attribute,

        /* static methods can take static variables. It can take normal methods or varaibles
         * only through object. Think of it as main function. It is the prime example of
         * static method.
         */

        public static void StaticMethods()
        {
            Console.WriteLine("This is static methods.");
            Console.WriteLine("It can be used without instantiating an object");
        }
    }

}
