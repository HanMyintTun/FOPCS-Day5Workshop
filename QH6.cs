using System;

namespace Day5Workshop
{
    class H6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write out a word:");
            string input1 = Console.ReadLine();
            string cutInput1 = H3.CutJunk(input1);

            Console.Write("Type out a series of characters to find (no more than 3): ");
            string input2 = Console.ReadLine();

            while (input2.Length > 3)
            {
                Console.WriteLine("I'm sorry, you must not have heard me.");
                Console.Write("Type out a series of characters to find (no more than 3): ");
                input2 = Console.ReadLine();
            }

            string cutInputLower1 = cutInput1.ToLower();
            string inputLower2 = input2.ToLower();
            bool check = H3.InString(cutInputLower1, inputLower2);


            if (check == true)
            {
                Console.WriteLine("TRUE");
            }

            else
            {
                Console.WriteLine("FALSE");   
            }
        }

        public static bool InString(string s1, string s2)
        {
            bool checking = false;

            for (int i = 0; i < (s1.Length - s2.Length + 1); i++)
            {
                string checkum1 = s1.Substring(i, s2.Length);
                string checkum2 = s2.Substring(0, s2.Length);

                if (checkum1 == checkum2)
                {
                    checking = true;
                }
            }

            return checking;
        }

        public static string CutJunk(string s)
        {
            string z, Z = "";
            for (int j = 0; j < s.Length; j++)
            {
                z = s.Substring(j, 1);

                switch (z)
                {
                    case " ":
                        s.Trim(' ');
                        break;

                    case ".":
                        s.Trim('.');
                        break;

                    case ",":
                        s.Trim('.');
                        break;

                    case "'":
                        s.Trim('\'');
                        break;

                    case "?":
                        s.Trim('?');
                        break;

                    case "!":
                        s.Trim('!');
                        break;

                    case "-":
                        s.Trim('-');
                        break;

                    case "\"":
                        s.Trim('\"');
                        break;

                    case ";":
                        s.Trim(';');
                        break;

                    case ":":
                        s.Trim(':');
                        break;

                    case "&":
                        s.Trim('&');
                        break;

                    default:
                        Z = Z + z;
                        break;
                }
            }
            return Z;
        }
    }
}
