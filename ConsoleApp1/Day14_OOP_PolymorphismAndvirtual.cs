using System;
using System.Collections.Generic;
using System.Text;

/* Polymorphis  means simply multiple implementation with singular function.
 * There are most useful two types of polymorphism : OverRide and OverLoad
 */

namespace ConsoleApp1
{
    class SuperClassI
    {
        public virtual void myFunc()  //virtual marks the fucntion to override in a sub class.
        {
            Console.WriteLine("This is original virtual function.");
            Console.WriteLine("You do not have to write here but");
            Console.WriteLine("You can still override function without virtual");
            Console.WriteLine("However, it marks the original of overRide functions");
        }
    }

    class SubClassI : SuperClassI
    {
        private int a;
        private double b;

        //Overload: similar to override, it allows multiple implementation.
        //howver, overload allows user to have different parameters.
        //The prime example of overloading is constructors and methods.
        //      I. numbers of parameter
        //      II.types of parameters
        //       III. order of parameter
        public SubClassI()
        {
            //default constructor
        }

        public SubClassI(int a) //we have a to assign to this.a
        {
            this.a = a;
        }

        public SubClassI(int a, int b) //we have a and b to assign.
        {
            this.a = a;
            this.b = b;
        }


        public override void myFunc()
        {
            Console.WriteLine("This is overRiden Virtual myFunc.");
            Console.WriteLine("override keyword marks the overriden function in sub class.");
        }
        /* Observing from virtual and override methods, we can see that
         *  I. inheritance is based on it,
         *  II. Only the contents inside of the block is changed.
         */
    }

    class Day14_OOP_PolymorphismAndvirtual
    {
    }
}
