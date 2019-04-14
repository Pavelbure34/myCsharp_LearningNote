using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /* C# is OOP. it has inheritane, encapsulation, and polymorphism.
     * We are gonna cover inheritance today.
     */
     class SuperClass
    {
        public int a = 0;
        public void myFunc()
        {
            Console.WriteLine("This is MotherClass My Func.");
        }
    }

    class SubClass : SuperClass
    {

    }

    sealed class SEALCLASS : SuperClass
    {
        //this is sealed class and it cannot be inherited.
        //however, it can receive inheritance.
    }
    class Day13_OOP_inheritance
    {
        void copyFunc()
        {
            SEALCLASS example2 = new SEALCLASS();
            example2.myFunc();
            SubClass example1 = new SubClass();
            Console.WriteLine(example1.a);
            example1.myFunc();
        }
    }
}
