using System;

namespace Slide2
{
    class Program
    {
        static void printArray(int[] a)
        {
            foreach (int i in a)
            {
                System.Console.WriteLine(i.ToString() + " ");
            }
        }
        
        static int[] insertion_sort(int[] a)
        //from slide
        //works
        {
            for (int j = 1; j < a.Length; j++)
            {
                var key = a[j];
                var i = j - 1;
                while (i >= 0 && a[i] > key)
                {
                    a[i + 1] = a[i];
                    i = i - 1;
                }
                a[i + 1] = key;
            }
            return a;
        }
        static int[] BubbleSort(int[] inputArray)
        {
            int temp;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length - 1; j++)
                {
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        temp = inputArray[j + 1];
                        inputArray[j + 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }

        static int[] BubbleSortSlide(int[] inputArray)
        //from slide
        //fk this
        {

            for (int i = 1; i < inputArray.Length - 1; i++)
            {
                for (int j = inputArray.Length - 1; j < (i + 1); j++)
                {
                    if (inputArray[j] < inputArray[j - 1])
                    {
                        var temp = inputArray[j + 1];
                        inputArray[j] = inputArray[j - 1];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }
        static int[] mergeSort(int[] array, int p, int r)
        {
            if (p < r)
            {
                var q = (p + r) / 2;
                mergeSort(array, p, q);
                mergeSort(array, q + 1, r);
                merge(array, p, q, r);
            }
            return array;
        }

        static int[] merge(int[] array, int p, int q, int r)
        {
            var n_one = q - p + 1;
            var n_two = r - 1;
            int[] L = {};
            int[] R = {};

            for (int i = 0; i < n_one; i++)
            {
                L[i] = array[p + 1 - 1];
            }
            for (int j = 0; j < n_two; j++)
            {
                R[j] = array[q + j];
            }
            var a = 1;
            var b = 1;
            for (int k = p; k < r; r++)
            {
                if (L[a] <= R[b])
                {
                    array[k] = L[a];
                    a = a + 1;
                }
                else
                {
                        array[k] = R[b];
                        b = b + 1;
                }
            }
            return array;
        }
        static void Main(string[] args)
        {

            var watch = System.Diagnostics.Stopwatch.StartNew();

            int[] unsortedlist = { 5, 2, 4, 6, 1, 3 };
            int[] unsortedlistTwo = { 8,3,2,9,7,1,5,4};



            int[] sortedlist = mergeSort(unsortedlistTwo,unsortedlistTwo[0],unsortedlistTwo[7]);
            printArray(sortedlist);



            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            System.Console.WriteLine("time: " + elapsedMs + "s");
        }
    }
}
