using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class BinarySearchAWord
    {

        public static int binarySearch(String[] arr, String x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                int res = x.CompareTo(arr[m]);

                if (res == 0)
                    return m;

                if (res > 0)
                    l = m + 1;

                else
                    r = m - 1;
            }

            return -1;
        }

        public static void StringInput()
        {
            String[] words = { "Hello", "world", "I", "am", "Shantanu" };
            String x = "I";
            int result = binarySearch(words, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index " + result);
        }
    }
}
    


