using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_396
{
    class Program
    {
        static double CelK(double k)
        {
            double res = k - 273.15;
            return res;
        }
        static double[] Masiv(double[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} day: ", i + 1);
                arr[i] = Convert.ToDouble(Console.ReadLine());
                while (arr[i]<223 || arr[i]>323)
                {
                    Console.Write("new value for {0} day: ", i + 1);
                    arr[i] = Convert.ToDouble(Console.ReadLine());
                }
            }
            return arr;
        }
        static double Min(double[] arr)
        {
            double min = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
                   
            }
            return min;
        }
        static double Min_C(double[] arr)
        {
            double min = CelK(arr[0]);
            for(int i = 1; i < arr.Length; i++)
            {
                if (min > CelK(arr[i]))
                {
                    min = CelK(arr[i]);
                }
            }
            return min;
        }
        static void Between(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(CelK(arr[i])>=10 && CelK(arr[i])<=30)
                {
                    Console.WriteLine(CelK(arr[i]));
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Number of days: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n<1 || n>31)
            {
                Console.Write("new value for n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            double[] a = new double[n];
            Masiv(a);
            
            Console.WriteLine("Minimal temperature in K is" + Min(a));
            Console.WriteLine("Minimal temperature in C is" + Min_C(a));

            Between(a);
            Console.ReadKey(true);
        }
    }
}
