using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_410
{
    class Program
    {
        static double[] Masiv(double[] arr, int n)
        {

            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write("arr[{0}]= ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        static double Max_element(double[] a)
        {
            double max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i])
                    max = a[i];
            }
            return max;
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
            double[] A = new double[n + 1];
            Masiv(A, n + 1);
            Console.WriteLine("The elemnts of B-array:");
            double[] B = new double[n + 1];
            Masiv(B, n + 1);
            Console.WriteLine("The elemnts of C-array:");
            double[] C = new double[n + 1];
            Masiv(C, n + 1);
            double mul = Max_element(A) * Max_element(B) * Max_element(C);
            Console.WriteLine("Multiple of max elements is {0:F2}", mul);

            //zad_410_3
            //for (int i = 1; i < C.Length; i++)
            //{
            //    C[i] = A[i] + Math.Pow(-1, i) * B[n];
            //    n--;
            //    Console.WriteLine("New C[{0}] = {1}", i, C[i]);
            //}

            //zad_411_3
            for (int i = 1; i < C.Length; i++)
            {
                C[i] = A[i] * B[n] - Math.Pow(A[n], 2);
                n--;
                Console.WriteLine("New C[{0}] = {1}", i, C[i]);
            }

            Console.ReadKey(true);
        }
    }
}
