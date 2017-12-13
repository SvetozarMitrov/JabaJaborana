using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_412
{
    class Program
    {
        static int[] Masiv(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write("arr[{0}]= ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        static int Broi(int[] arr)
        {
            int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (i % 2 != 0 && arr[i] % 5 == 0)
                    count++;
            }
            return count;
        }
        static double Average(int[] arr)
        {
            int count = 0;
            double sum = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + arr[i];
                    count++;
                }

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
            Console.WriteLine("Elements of A:");
            int[] A = new int[n + 1];
            Masiv(A);
            Console.WriteLine("Elements of B:");
            int[] B = new int[n + 1];
            Masiv(B);
            Console.WriteLine("Elements of C:");
            int[] C = new int[n + 1];
            Masiv(C);
            Console.WriteLine("The number of the elements of A with odd indexes and %5=0 is {0}", Broi(A));
            Console.WriteLine("The number of the elements of B with odd indexes and %5=0 is {0}", Broi(B));
            Console.WriteLine("The number of the elements of C with odd indexes and %5=0 is {0}", Broi(C));
            double sr_geo = Math.Pow(Broi(A) * Broi(B) * Broi(C), 1 / 3.0);
            Console.WriteLine("Sredno geometrichno e {0:f2}", sr_geo);

            //zad_412_3
            //for (int i = 1; i < C.Length; i++)
            //{
            //    C[i] = (A[n] - B[n]) * (A[i] - B[i]);
            //    n--;
            //    Console.WriteLine("New C[{0}]= {1}", i, C[i]);
            //}

            Console.WriteLine("The average of the elements of A with indexes %3=0 is {0:F2}", Average(A));
            Console.WriteLine("The average of the elements of B with indexes %3=0 is {0:f2}", Average(B));
            Console.WriteLine("The average of the elements of C with indexes %3=0 is {0:f2}", Average(C));
            double sr_kv = Math.Sqrt((Math.Pow(Average(A), 2) + Math.Pow(Average(B), 2) + Math.Pow(Average(C), 2)) / 3);
            Console.WriteLine("Sredno kvadratichno of {0:f2}, {1:f2}, {2:F2} is {3:F2}", Average(A), Average(B), Average(C), sr_kv);

            //zad_413_3
            for (int i = 1; i < C.Length; i++)
            {
                C[i] = A[n] * A[n] + B[i] * B[i] * B[i] * B[i];
                n--;
                Console.WriteLine("New C[{0}]= {1}", i, C[i]);
            }
            Console.ReadKey(true);
        }
    }
}
