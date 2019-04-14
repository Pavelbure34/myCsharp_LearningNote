using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /* Enums are bundle of constants data.
     * The initial value is 0 by default. But you can specify it.
     * The next following item is incremented by one.
     *  Usually it is used to indicate months and weeks and dates.
     */

     enum Week {Mon = 1, Tues, Wednes, Thurs, Fri, Satur, Sun };
    class Day19_Enums
    {
        void copyMethod()
        {
            Console.WriteLine(Week.Mon);  //printout 1
            Console.WriteLine((Week.Tues));  //printout 2
            Console.WriteLine(Week.Wednes);
            Console.WriteLine((int)Week.Thurs);
            Console.WriteLine((int)Week.Fri);
            Console.WriteLine((int)Week.Satur);
            Console.WriteLine((int)Week.Sun);
            Console.Read();
        }
    }
}
