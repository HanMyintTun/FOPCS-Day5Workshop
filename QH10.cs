using System;

namespace Day5Workshop
{
    class H10   //unfinished... try to get to this another time
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int R1 = rnd.Next(2, 5);
            int R2 = rnd.Next(2, 5);
            int R3 = rnd.Next(2, 4); 
                
            int[,] array1 = H10.InitializeArray1(R1, R3);
            int[,] array2 = H10.InitializeArray2(R2, R3);

            PrintArray(array1);
            Console.WriteLine();
            PrintArray(array2);
            Console.WriteLine();

            int[,] arrayFinal = H10.MatrixMultiply(array1, array2);
            PrintArray(arrayFinal);
        }

        public static int[,] InitializeArray1(int a, int b)
        {
            int[,] newArray1 = new int[a, b];
            Random r = new Random();
            int x;

            for (int i = 0; i < newArray1.GetLength(0); i++)
            {
                for (int j = 0; j < newArray1.GetLength(1); j++)
                {
                    x = r.Next(1, 10);
                    newArray1[i, j] = x;
                    x = 0;
                }
            }

            return newArray1;
        }

        public static int[,] InitializeArray2(int a, int b)
        {
            int[,] newArray2 = new int[b, a];
            Random r = new Random();
            int x;

            for (int i = 0; i < newArray2.GetLength(0); i++)
            {
                for (int j = 0; j < newArray2.GetLength(1); j++)
                {
                    x = r.Next(1, 20);
                    newArray2[i, j] = x;
                    x = 0;
                }
            }

            return newArray2;
        }

        static int[,] MatrixMultiply(int[,] A, int[,] B)
        {
            int[,] X = new int[A.GetLength(0), B.GetLength(1)];
            int sum = 0;

            for (int i = 0; i < A.GetLength(0); i ++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    for (int k = 0; k < A.GetLength(1); k++)
                    {
                        int x = A[i, k] * B[k, j];
                        sum = sum + x;
                        x = 0;
                    }

                    X[i, j] = sum;
                    sum = 0;
                }
            }

            return X;

        }

        static void PrintArray(int[] testArr)
        {
            Console.WriteLine(string.Join(", ", testArr));
            Console.WriteLine();
        }

        static void PrintArray(int[,] testArr)
        {
            for (int i = 0; i < testArr.GetLength(0); i++)
            {
                for (int j = 0; j < testArr.GetLength(1); j++)
                {
                    Console.Write(testArr[i,j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
