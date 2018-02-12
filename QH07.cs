using System;

namespace Day5Workshop
{
    class H7
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

        }

        public static int[] SetArray(int[] arr, int value)
        {
            int[] setArray = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                setArray[i] = value;
            }

            return setArray;
        }

        public static int[] SetSingleArray(int[] arr)
        {

            Console.WriteLine("What array size would you like to create: ");
            int size = Int32.Parse(Console.ReadLine());

            int[] setSingleArray = new int[size];
            int p, q;
            bool numCheck = false;

            for (int i = 0; i < size; i++)
            {
                Console.Write("Please put in an integer into position {0} of the array: ", i);
                string input = Console.ReadLine();
                numCheck = Int32.TryParse(input, out q);

                while (numCheck == false)
                {
                    Console.WriteLine("I'm sorry but that's not an integer, a whole number.");
                    Console.Write("Please try again: ");
                    input = Console.ReadLine();
                    numCheck = Int32.TryParse(input, out q);
                }

                p = Int32.Parse(input);
                setSingleArray[i] = p;
            }

            return setSingleArray;
        }
    }
}
