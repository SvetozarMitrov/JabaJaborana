using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_414
{
    class Program
    {
        static double[] Masiv(double[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write("arr[{0}]= ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        static double Sum(double[] arr)
        {
            double sum = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] > 0 && arr[i] <= 100)
                    sum = sum + arr[i];
            }
            return sum;
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
            Console.WriteLine("Elements of A:");
            double[] A = new double[n + 1];
            Masiv(A);
            Console.WriteLine("Elements of B:");
            double[] B = new double[n + 1];
            Masiv(B);
            Console.WriteLine("Elements of C:");
            double[] C = new double[n + 1];
            Masiv(C);
            Console.WriteLine("Sum of odd elements of A in the interval (0,100] is {0}", Sum(A));
            Console.WriteLine("Sum of odd elements of B in the interval (0,100] is {0}", Sum(B));
            Console.WriteLine("Sum of odd elements of C in the interval (0,100] is {0}", Sum(C));

            if (Sum(A) > Sum(B) && Sum(A) > Sum(C))
                Console.WriteLine("The max sum is " + Sum(A));
            else if (Sum(B) > Sum(A) && Sum(B) > Sum(C))
                Console.WriteLine("The max sum is " + Sum(B));
            else
                Console.WriteLine("The max sum is " + Sum(C));

            //zad_414_3
            //for (int i = 1; i < C.Length; i++)
            //{
            //    C[i] = Math.Pow(A[i], 2 * i - 1) * Math.Pow(B[i], 2 * i);
            //    Console.WriteLine("New C[{0}]= {1}", i, C[i]);
            //}

            //zad_415_3
            for (int i = 1; i < C.Length; i++)
            {
                C[i] = A[i]*B[n];
                n--;
                Console.WriteLine("New C[{0}]= {1}", i, C[i]);
            }

            Console.ReadKey(true);
        }
    }
}
