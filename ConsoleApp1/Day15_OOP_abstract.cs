using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /* instead of using virtual and override keyword to mark the polymorphism in methods,
     * you can have abstract keywords. Below is the abstract class including abstract method.
     * There are number of things about this,
     *      I. abstract members are only in the abstract class.
     *      II. It needs to be overRiden in sub classes.
     *      III. abstract class can have normal members.
     *      IV. it works as the superclass, which cannot stand on its alone. 
     *      
     *  When they are used,
     *       I. provides the blueprint for other classes.
     */

    abstract class AbsExample
    {
        public abstract void myFunc();

        public void myNormalFunc()
        {
            Console.WriteLine("Abstract class can have normal member.");
        }
    }

    class AbsExample2 : AbsExample
    {
        public override void myFunc()
        {
            throw new NotImplementedException();
            Console.WriteLine("Abstract method has to be overriden in subclass");
        }
    }
    class Day15_OOP_abstract
    {
    }
}
