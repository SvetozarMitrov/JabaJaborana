using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_399
{
    class Program
    {
        static int[] Masiv(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} day: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                while (arr[i] < 0)
                {
                    Console.Write("new value for {0} day: ", i + 1);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return arr;
        }
        static int Number(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    count++;
                    Console.WriteLine("{0} without rain", i + 1);
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.Write("n= ");
            string p = Console.ReadLine();
            int n; int.TryParse(p, out n);
            while (n <= 0)
            {
                Console.Write("new value for n= ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("elements of A:");
            int[] A = new int[n];
            Masiv(A);
            Console.WriteLine("elements of B:");
            int[] B = new int[n];
            Masiv(B);
            Console.WriteLine("elements of C:");
            int[] C = new int[n];
            Masiv(C);
            Console.WriteLine("Days without rain in A " + Number(A));
            Console.WriteLine("Days without rain in B " + Number(B));
            Console.WriteLine("Days without rain in C " + Number(C));
            Console.ReadKey(true);
        }
    }
}
