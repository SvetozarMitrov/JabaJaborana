using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_398
{
    class Program
    {
        static int[] Masiv(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} day: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        static double Average(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            double average = (double)sum / arr.Length;
            return average;
        }
        static int NO(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.Write("days: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n <= 0 || n > 31)
            {
                Console.Write("new value for days: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            int[] A = new int[n]; Masiv(A);
            Console.WriteLine("Average for A is {0:F2}", Average(A));
            int[] B = new int[n]; Masiv(B);
            Console.WriteLine("Average for B is {0:F2}", Average(B));
            int[] C = new int[n]; Masiv(C);
            Console.WriteLine("Average for C is {0:F2}", Average(C));
           
            for (int i = 0; i < A.Length; i++)
            {
                if (Average(A) < A[i])
                    Console.WriteLine("{0} day in A", i + 1);
                if (A[i] == 0)
                    Console.WriteLine(i + 1 + " day is without rain");
            }
            for (int i = 0; i < B.Length; i++)
            {
                if (Average(B) < B[i])
                    Console.WriteLine("{0} day in B", i + 1);
                if (B[i] == 0)
                    Console.WriteLine(i + 1 + " day is without rain");
            }
            for (int i = 0; i < C.Length; i++)
            {
                if (Average(C) < C[i])
                    Console.WriteLine("{0} day in C", i + 1);
                if (C[i] == 0)
                    Console.WriteLine(i + 1 + " day is without rain");
            }
            Console.WriteLine(NO(A) + " in A");
            Console.WriteLine(NO(B) + " in B");
            Console.WriteLine(NO(C) + " in C");
            Console.ReadKey(true);
        }
    }
}
