using System;

namespace Day5Workshop
{
    class H1
    {
        static void Main()
        {
            int num = H1.ReadInteger("Type in an integer: ");
            Console.WriteLine(num);
        }

        public static int ReadInteger(string message)
        {
            int a, n;
            bool isNum = false;
            Console.Write(message);
            string input = Console.ReadLine();

            isNum = int.TryParse(input, out n);

            while (isNum == false)
            {
                Console.Write("That seems to be incorrect. Please type in an integer: ");
                input = Console.ReadLine();
                isNum = int.TryParse(input, out n);
            }

            a = Int32.Parse(input);
            return a;
        }
    }
}
