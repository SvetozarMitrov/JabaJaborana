using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_402
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
        static int Min(int[] arr)
        {
            int min = int.MaxValue;
            for (int i = 0; i <= arr.Length-1; i++)
            {
                if (arr[i] == 0)
                {
                    continue;
                }
                else if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            if (min == int.MaxValue)
                min = 0;
            return min;
        }
        static int Max(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    continue;
                else if (arr[i] > max)
                    max = arr[i];
            }
            if (max == int.MinValue)
                max = 0;
            return max;
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
            Console.WriteLine("Min in A is " + Min(A));
            Console.WriteLine("Max in A is " + Max(A));
            int[] B = new int[n]; Masiv(B);
            Console.WriteLine("Min in B is " + Min(B));
            Console.WriteLine("Max in B is " + Max(B));
            int[] C = new int[n]; Masiv(C);
            Console.WriteLine("Min in C is " + Min(A));
            Console.WriteLine("Max in C is " + Max(C));
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == Min(A))
                    Console.WriteLine(i + 1);
            }
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == Min(B))
                    Console.WriteLine(i + 1);
            }
            for (int i = 0; i < C.Length; i++)
            {
                if (C[i] == Min(C))
                    Console.WriteLine(i + 1);
            }
            Console.ReadKey(true);
        }
    }
}
