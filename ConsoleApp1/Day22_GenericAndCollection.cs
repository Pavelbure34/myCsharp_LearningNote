using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Day22_GenericAndCollection
    {
        /* Similar to C++'s template, you have generic methods and classes.
         * YOu just simply replace all the data type in method and class with 
         * generic T or the other letter.
        */
        public static void Print<T>(T item)
        {
            Console.Write(item);
        }

        class ExempClass<T>
        {
            private T a;

            public ExempClass(T item)
            {
                a = item;
            }

            public T printoutA()
            {
                return a;
            }
        }

        /* Collection is a dynamically growing array.
         * The first Collection is list.
        */
        public static void CollectionExample()
        {
            List<int> intList = new List<int>();      //int list. can be applied to every data type.
            List<Char> charList = new List<Char>();   //this is the format of list.
            //list methods.
            charList.Add('a'); //add item to the list
            charList.Add('b');
            Console.WriteLine(charList[0]); //can be accessed by index.
            charList.Clear(); //empty the list
            charList.Contains('a'); //check if the item is there, returns boolean
            charList.Insert(0, 'g'); //index comes and the item comes and item is inserted at the given index.
            charList.Reverse(); //reverse the list.
        }

        /* The second Collection is Dictionary. key-value pair is one item
         * The third is Queue<T> -> a first of collection of objects -> FIFO method
         * The fourth is STack<T> -> a last of collection of objects -> LIFO method
         */
         public static void CollectionExample1()
        {
            Dictionary<string, int> People = new Dictionary<string, int>(); //this is dictionary.
            //there are few characteristics of Dictionary.

        }
    }
}
