using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_397
{
    class Program
    {
        static double Kelvin(double t)
        {
            double res = t + 273.15;
            return res;
        }
        static double[] Masiv(double[] temp)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write("{0} day: ", i + 1);
                temp[i] = Convert.ToDouble(Console.ReadLine());
                while (temp[i] < -50 || temp[i] > 50)
                {
                    Console.Write("New value for {0} day: ", i + 1);
                    temp[i] = Convert.ToDouble(Console.ReadLine());
                }
            }
            return temp;
        }
        static double Max(double[] temp)
        {
            double max = temp[0];
            for (int i = 1; i <= temp.Length - 1; i++)
            {
                if (temp[i] > max)
                    max = temp[i];
            }
            return max;
        }
        static double Max_K (double[] temp)
        {
            double max = Kelvin(temp[0]);
            for (int i = 1; i <= temp.Length - 1; i++)
            {
                if (Kelvin(temp[i]) > max)
                    max = Kelvin(temp[i]);
            }
            return max;
        }
        static double Min_K(double[] temp)
        {
            double min = Kelvin(temp[0]);
            for (int i = 1; i <= temp.Length - 1; i++)
            {
                if (Kelvin(temp[i]) < min)
                    min = Kelvin(temp[i]);
            }
            return min;
        }
        static double Min(double[] temp)
        {
            double min = temp[0];
            for (int i = 1; i <= temp.Length - 1; i++)
            {
                if (temp[i] < min)
                    min = temp[i];
            }
            return min;
        }
        static double Razlika(double[] temp)
        {
            double res = Max(temp) - Min(temp);
            return res;
        }
        static double Razlika_K(double[] temp)
        {
            double res_k = Max_K(temp) - Min_K(temp);
            return res_k;
        }
        static void Output (double[] temp)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine("{0} day is {1}", i + 1, Kelvin(temp[i]));
            }
        }
        static void Main(string[] args)
        {
            Console.Write("days: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n<=0 || n >31)
            {
                Console.Write("new value for days: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            double[] arr = new double[n];
            Masiv(arr);
            Console.WriteLine("Max in C is " + Max(arr));
            Console.WriteLine("Min in C is " + Min(arr));
            Console.WriteLine("Razlikata e " + Razlika(arr));
            Console.WriteLine("Max in K is " + Max_K(arr));
            Console.WriteLine("Min in K is " + Min_K(arr));
            Console.WriteLine("Razlikata e " + Razlika_K(arr));
            Output(arr);
            Console.ReadKey(true);
        }
    }
}
