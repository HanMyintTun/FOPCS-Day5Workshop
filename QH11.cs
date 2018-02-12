using System;

namespace Day5Workshop
{
    class H11
    {
        public static void Main(string[] args)
        {
            double[] A = H11.InitializeArray();
            PrintArray(A);

            double[] B = ProcessArray(A, DoubleOps);
            PrintArray(B);

            double[] C = ProcessArray(A, SqRootOps);
            PrintArray(C);

            double[] D = ProcessArray(A, Square);
            PrintArray(D);
        }

        static double DoubleOps(double x) { return x * 2; }
        static double SqRootOps(double x) { return Math.Sqrt(x); }
        static double Square(double x) { return x * x; }

        delegate double Operation(double x);

        static double[] ProcessArray(double[] arr, Operation ops)
        {
            double[] newArray = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = ops(arr[i]);      //applying ops to each element in the array
            }

            return newArray;
        }

        public static double[] InitializeArray()
        {
            Random r = new Random();
            int x = r.Next(2, 10);
            double[] newArray1 = new double[x];

            for (int i = 0; i < newArray1.Length; i++)
            {
                double y = r.Next(1, 20);
                newArray1[i] = y;
                y = 0;
            }

            return newArray1;
        }

        static void PrintArray(double[] testArr)
        {
            Console.WriteLine(string.Join(", ", testArr));
            Console.WriteLine();
        }
    }
}
