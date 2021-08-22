using System;

namespace AlgorithmProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter \n1. Permutations of a String" +
                                    "\n2. Binary Search A Word" +
                                    "\n3. Insertion Sort" +
                                    "\n4. Bubble Sort");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    PermutationsOfAString.StringInput();
                    break;

                case 2:
                    BinarySearchAWord.StringInput();
                    break;

                case 3:
                    InsertionSort.StringInput();
                    break;

                case 4:
                    BubbleSort.Input();
                    break;
            }
        }
    }
}
        
    

