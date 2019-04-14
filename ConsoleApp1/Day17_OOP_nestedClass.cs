using System;
using System.Collections.Generic;
using System.Text; //using keyword is equivalent to #include in CPP.

namespace ConsoleApp1
{
    /* Nested class is class within the class.
     *      It is cosidered as part of member.
     *      It can have access specifier <public, private, protected>
     *      It can gain access to the outer class' member.
     *      It is a proper class.
     */

    class HumanBody //this is what nested class look like.
    {

        class Head
        {

        }

        class Arm  //each nested class can have its own nested classes.
        {
            class Shoulder
            {

            }

            class Hand
            {

            }
        }

        class Leg
        {

        }
    }

    class Day17_OOP_nestedClass
    {
    }
}
