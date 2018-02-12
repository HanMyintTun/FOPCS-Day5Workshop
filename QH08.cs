using System;

namespace Day5Workshop
{
    class H8
    {
        public static void Main(string[] args)
        {
            
            Console.Write("What numeber would you like to put into an array: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("What size array would you like: ");
            int num2 = Int32.Parse(Console.ReadLine());

            int[] myArray = new int[num2];
            int[] result = H7.SetArray(myArray, num1);

            Console.WriteLine(string.Join(", ", result));

            Console.Write("What new size would you like for the array? ");
            int num3 = Int32.Parse(Console.ReadLine());

            int[] newResult = H8.ResizeArray(result, num3);

            Console.WriteLine(string.Join(", ", newResult));

        }

        public static int[] ResizeArray(int[] arr, int newSize)
        {
            int[] setNewArray = new int[newSize];
            int numMove = arr[0];

            for (int i = 0; i < newSize; i++)
            {
                setNewArray[i] = numMove;
            }

            return setNewArray;
        }
    }
}
