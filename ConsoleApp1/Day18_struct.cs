using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /* Struct, you might have heard it from C, is also included in the C#.
     * Struct cannot include default constructor while class can. And Both struct and
     * class can include member methods and field variables. So when
     *  you want to use struct:
     *      small data structure that is not inteded to be modified after its creation
     *      it cannot include virtual methods.
     *  you want to use class:
     *      more complex data structure that it requires modification and more behaviours.
     * Other than that, stuct shares the same charactersitics. 
     *      it is sealed by default
     *      it can be instantiated into an object.
     */

    struct animal //it is sealed by default so..cannot be inherited
    {
        public string specie;

        //cannot have default constructor.
        public animal(string specie)
        {
            this.specie = specie;
            Console.WriteLine("its species is {0}", this.specie);
        }

        public void Action(string behavior)
        {
            Console.WriteLine(behavior);
        }

    }

    struct MyException : Exception
    {

    }

    class Day18_struct
    {
        void copyFunction()
        {
            animal Dog = new animal("Canine");
            Dog.Action("Bark!");
        }
    }
}
