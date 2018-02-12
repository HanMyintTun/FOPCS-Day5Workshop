using System;

namespace Day5Workshop
{
    class H5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("For numbers 1 to 100, the hexadecimal equivalents are:");

            for (int i = 0; i < 100; i++)
            {
                Console.Write(H5.FindHexa(i)+" ");
            }
           
            Console.WriteLine();

            for (int j = 0; j < 100; j++)
            {
                string hexOutput = String.Format("{0:X}", j);
                Console.Write(hexOutput + " ");
            }
        }

        public static string FindHexa(int n)
        {
            string[] HexArray = new string[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"};
            int num, r; 
            string numValue, remainValue, hexadecimal;

            num = n / 16;
            r = n % 16;

            numValue = HexArray[num];
            remainValue = HexArray[r];

            if (numValue == "0")
            {
                hexadecimal = remainValue;
            }

            else
            {
                hexadecimal = numValue + remainValue; 
            }

            return hexadecimal;
        }
    }
}
