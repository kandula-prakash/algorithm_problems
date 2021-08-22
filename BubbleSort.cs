using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class BubbleSort
    {
        static void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        // Driver method
        public static void Input()
        {
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };
            bubbleSort(numbers);
            Console.WriteLine("Sorted array");
            printArray(numbers);
        }
    }
}

