using System;

namespace Slide1
{

    class Program
    {
        static int sequential_search(int[] inputArray, int find)
        //also called linear search
        //Simplest, but least efficient
        //Examines each element SEQUENTIALLY, from the first index to the last
        {
            for (int i = 0; i < inputArray.Length; i++) //loop through the inputArray
            {
                if (inputArray[i] == find)              //if the value on index i equals the value u want to "find"
                {                                       // inputArray[i]  -> the value in the inputArray at index i 
                    return i;                           //return 1 (found)
                }
            }
            return -1;                                  //else return -1 (value not found)
        }
        static int binary_search(int[] inputArray, int find)
        //standard search algorithm for a SORTED sequence
        //*requires the order of elements 
        //divide the sequence in two and FOCUSES on the half which could contain the element
        {                                                   //example
            int low = 0;                                    //low          middle           high
            int high = inputArray.Length - 1;       //values//1 ,   2,3,   5      ,9,10,16, 20
            while (low <= high)                     //index///0     1 2    3       4 5  6   7            
            {
                int middle = (low + high) / 2;      //middle = (0 + 7) / 2 = 3.5 -> 3       
                if (find < inputArray[middle])      //if find is lower than 5
                {
                    high = middle - 1;              //assign "high" to 3 - 1 -> 2    !!index 2 NOT value 2
                }
                else if (find > inputArray[middle]) //if find is higher than 5
                {
                    low = middle + 1;               //assign "low"to 3 + 1 -> 4      !!index 4 NOT value 4 
                }
                else
                {
                    return middle;                  //if find == value at index middle -> return that value
                }
            }
            return -1;                              //value not inputArray
        }
        static int binary_search_re(int[] list, int low, int high, int find)
        //RECURSIVE
        {

            if (low > high)
            {
                return -1;
            }
            int middle = (low + high) / 2;
            if (list[middle] > find)
            {
                return binary_search_re(list, low, middle - 1, find);
            }
            else if (list[middle] < find)
            {
                return binary_search_re(list, middle + 1, high, find);
            }
            else
            {
                return middle;
            }
        }



        static void Main(string[] args)
        {
            //int[] listone = { 1, 4, 7, 8, 9, 12, 15, 16, 20, 21, 25 };
            int[] listtwo = { 2, 4, 7, 9, 10, 22, 27, 50, 77, 88, 100, 123, 155, 188 };

            //System.Console.WriteLine("found on index: " + sequential_search(listone, 9));
            //System.Console.WriteLine("found on index: " + binary_search_re(listtwo, 0, listtwo.Length - 1, 155));
            System.Console.WriteLine("found on index: " + binary_search(listtwo, 188));
        }
    }

}
