using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_408
{
    class Program
    {
        static double[] Masiv(double[] arr, int n)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}]= ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        static double Average_7(double[] arr)
        {
            double sum = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 7 == 0)
                    sum = sum + arr[i]; count++;
            }
            double average = sum / count;
            return average;
        }
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n < 2 || n > 30)
            {
                Console.Write("new n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The elemnts of A-array:");
            double[] A = new double[n];
            Masiv(A, n);
            Console.WriteLine("The elemnts of B-array:");
            double[] B = new double[n];
            Masiv(B, n);
            Console.WriteLine("The elemnts of C-array:");
            double[] C = new double[n];
            Masiv(C, n);

            // zad 408_3
            //for (int i = 0; i < C.Length; i++)
            //{
            //    C[i] = A[i] + (Math.Pow((double)n - 1, 2) + 1) * B[n - 1];
            //    n--;
            //    Console.WriteLine("New C[{0}]= {1}", i, C[i]);
                
            //}

            Console.WriteLine("Average of A is {0:F2}", Average_7(A));
            Console.WriteLine("Average of B is {0:F2}", Average_7(B));
            Console.WriteLine("Average of C is {0:F2}", Average_7(C));
            if (Average_7(A) > Average_7(B) && Average_7(B) > Average_7(C))
                Console.WriteLine("Minimal average is " + Average_7(C));
            if (Average_7(C) > Average_7(B) && Average_7(B) > Average_7(A))
                Console.WriteLine("Minimal average is " + Average_7(A));
            else
                Console.WriteLine("Minimal average is " + Average_7(B));

            //zad_409_3 за да тръгне трябва да бъде изключено условие 408_3
            for (int i = 0; i < C.Length; i++)
            {
                C[i] = A[n - 1] + (n - 1 - 1) * B[i];
                n--;
                Console.WriteLine("New C[{0}]= {1}", i, C[i]);

            }
            Console.ReadKey(true);
        }
    }
}
