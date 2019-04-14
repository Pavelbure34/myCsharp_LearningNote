using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface interfaceExample //it is pure abstract..
    {
        void myFunc();
        //all the member methods in interface are abstract and public by default
        //interface cannot hold field(variables).
        //inheritance of multiple interfaces are possible.
        //when overriding abstract member in interface, override keyword is not need.
    }

    interface interExample1
    {
        void myFunc2();
    }

    class Example1 : interExample1, interfaceExample
    {
        //multiple inheritance!
        public void myFunc()
        {
            //all the abstract methods in interface has to be implemented.
        }

        public void myFunc2()
        {

        }
    }

    class Day16_OOP_interface
    {
    }
}
