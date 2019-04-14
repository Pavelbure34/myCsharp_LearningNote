using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Day04_Methods
    {
        /* Method is a block of codes that are
         *      I. reusable
         *      II. prevent code duplciation for that.
         *      III.
         */
         static void myFunc()
        {
            //this is the basic format of method.
        }
       
        //you can assign the value from the method.
        /* Similar to pointer, C# has left pointer in C#
         * as different methods called reference and output.
         * 
         * I. pass by reference. 
         *      a.reset the variable.
         *      b.in the argument of the method, put ref.
         *      c. in the block, include a value to assign when a variable comes in.
         *      
         * II. pass by output
         *      a. do not reset the variable.
         *      b. in the argument of the method, put out.
         *      c. in the block, include the value to reset.
         *  
         *  See the CopyMain to see how it is used.
         */
        static void setInt_ref(ref int b)
        {
            b = 15;
        }

        
        static  void setInt_out(out int b)
        {
            b = 16;
        }

        void MainCopy()
        {
            int a = 0;
            setInt_ref(ref a);

            int b;
            setInt_out(out b);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.Read();
        }
    }
}
