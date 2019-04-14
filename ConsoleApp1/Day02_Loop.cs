using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Day02
    {
        void WhileLoop()
        {
            int i = 1;
            while (i < 10)
            {
                Console.Write("{0}, ", i);
                if (i % 3 == 0)
                    Console.WriteLine();
                i++;
            }
            Console.Read();
        }

        void ForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}, ", i);
            }
       
        }

    }
}
