using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /* Arrays are a bundle of data. Instead of managing multiple data
     * one by one, Array allows user to collect all the item he or she wants
     * to manipulate or manage into a single bundle that organizes them in a order called
     * index. By calling index, you can simply view it, modify them.
     */
    class Day06_Arrays
    {
        public void ArrayExample1()
        {
            int[] intArr = new int[5]; //this creates a int-type array with length of 5.
            intArr[0] = 1;
            intArr[1] = 2;
            intArr[2] = 3;
            intArr[3] = 4;
            intArr[4] = 5;
            Console.WriteLine(intArr.ToString()); //toString method prints out all the element in the array.
        }

        static void ArrayExample2()
        {
            int[] intArr = { 1, 2, 3, 4, 5 };
            //it is equivalent to the array above.
        }

        static void ForeachLoop()
        {
            /* here, in order to see each item in the array, 
             * use foreach loop. it is equivalent to
             * for item in list in Python.
             */
            int[] intArr = { 1, 2, 3, 4, 5 };
            foreach (int i in intArr) //you have the type of i according to the array.
            {
                Console.Write("{0}, ", i);
            }
        }

        static void MultiDimenArray()
        {
            int[,] intArr = new int[2, 2]; //array with 2 x 2.
            intArr[0, 0] = 0;
            intArr[0, 1] = 1;
            intArr[1, 0] = 2;
            intArr[1, 1] = 3;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0}, ", intArr[i, j]);
                }
            }

        }

        static void JaggedArray()
        {
            int[][] arrArr = new int[8][];
            //this is a array of arrays. arrArr itself is a singular array containing
            //different array for element which with different length.
        }

        public int Max(int[] arr)
        {
            int max = arr[0];
            foreach (int i in arr)
            {
                if (i > max)
                    max = i;
            }
            return max;
        }
        static int Min(int[] arr)
        {
            int min = arr[0];
            foreach (int i in arr)
            {
                if (i < min)
                    min = i;
            }
            return min;
        }

        static int Sum(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
                sum += i;
            return sum;
        }


        public void ArrayProperty_Methods()
        {
            int[] intArr = { 1, 2, 3 };
            //Here are Array Methods.
            //1. Length! number of items to hold.
            Console.WriteLine(intArr.Length); // prints out 3.

         
            int a = Max(intArr);
            Console.WriteLine(a);
            
            int b = Min(intArr);
            Console.WriteLine(b);
          
            int sum = Sum(intArr);
            Console.WriteLine(sum);

            int[,] intArr2 = new int[2, 2];
            //5. Dimension of the array.
            Console.WriteLine(intArr2.Rank); //prints out 2.

        }

    }
}
