using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /* When the class represents list, arrays and collection, you can use indexer.
     * Below is the basic exemplery format.
     * Note that it use this keyword to use getter and setter method.
     */
    class IndexerExample
    {
        private int[] intArr = new int[5];

        public int this[int index]
        {
            get //use getter to see the item.
            {
                return intArr[index];
            }

            set //use setter to store it.
            {
                intArr[index] = value;
            }
        }
    }

    class Day11_indexer
    {
        void copyFunc()
        {
            IndexerExample INDEXER = new IndexerExample();
            INDEXER[0] = 30;
            Console.WriteLine(INDEXER[0]);
        }
    }
}
