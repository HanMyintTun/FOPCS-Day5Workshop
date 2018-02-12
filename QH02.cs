using System;

namespace Day5Workshop
{
    class H2
    {
        public static void Main(string[] args)
        {
            int[] myArray = new int[] { 0, 3, 53, 78, 2 };
            H2.PrintArray(myArray);
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
