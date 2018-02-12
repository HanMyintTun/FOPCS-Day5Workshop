using System;

namespace Day5Workshop
{
    class H62
    {
        public static void Main(string[] args)
        {
            Console.Write("Type out a word: ");
            string getWord = Console.ReadLine();
            string word = getWord.ToLower();
            Console.Write("Choose a character to find in the string: ");
            string getChar1 = Console.ReadLine();
            string charSelect1 = getChar1.ToLower();
            char cS1 = Convert.ToChar(charSelect1);
            Console.Write("Choose a character to replace it with: ");
            string getChar2 = Console.ReadLine();
            string charSelect2 = getChar2.ToLower();
            char cS2 = Convert.ToChar(charSelect2);


            string result = H62.substitute(word, cS1, cS2);
            Console.WriteLine(result);


        }

        public static string substitute(string s, char c1, char c2)
        {
            bool checking = false;
            string newString = "", toform = "";

            while (checking == false)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    string checkIn = Convert.ToString(c1);
                    string check = s.Substring(i, 1);

                    if (check == checkIn)
                    {
                        checking = true;
                    }
                }

                if (checking == false)
                {
                    Console.WriteLine("\nI'm sorry, there doesn't seem to be any {0}", c1);
                    Console.Write("Please select another character: ");
                    c1 = Convert.ToChar(Console.ReadLine());
                }
            }


            if (checking == true)
            {
                for (int i = 0; i < (s.Length); i++)
                {
                    string input = s.Substring(i, 1);
                    char checkChar = Convert.ToChar(input);

                    if (checkChar == c1)
                    {
                        checkChar = c2;
                    }

                    string toPut = Convert.ToString(checkChar);

                    if (i == 0)

                    {
                        toform = toPut.ToUpper();
                    }

                    else
                    
                    {
                        toform = toPut;
                    }

                    newString = newString + toform;
                }
            }

            return newString;
        }
    }
}
