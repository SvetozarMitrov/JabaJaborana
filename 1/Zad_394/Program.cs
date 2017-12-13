using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_394
{
    class Program
    {
        static double Faren(double t)
        {
            double Temp_F = 1.8 * t + 32;
            return Temp_F;
        }
        static double[] Masiv(double[] temp)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write("{0} day: ", i + 1);
                temp[i] = Convert.ToDouble(Console.ReadLine());
                while (temp[i] < -50 || temp[i] > 50)
                {
                    Console.Write("Enter a new value. {0} day: ", i + 1);
                    temp[i] = Convert.ToDouble(Console.ReadLine());
                }
            }
            return temp;
        }
        static double OutPut(double[] sr_temp, int n)
        {
            double sum = 0;
            for (int i = 0; i < sr_temp.Length; i++)
            {
                sum = sr_temp[i] + sum;
            }
            double average = sum / n;
            return average;
        }
        static double OutPut_F(double[] sr_temp, int n)
        {
            double sum_2 = 0;
            for (int i = 0; i < sr_temp.Length; i++)
            {
                sum_2 = Faren(sr_temp[i]) + sum_2;
            }
            double avg = sum_2 / n;
            return avg;
        }
        static void Over(double[] over)
        {
            for (int i = 0; i < over.Length; i++)
            {
                if (Faren(over[i]) > 50)
                {
                    Console.WriteLine("Over " + Faren(over[i]));
                }
            }
        }
        static double Min(double[] min)
        {
            double minimal = min[0];
            foreach(double p in min)
            {
                if (minimal > p)
                    minimal = p; 
            }
            return minimal;
        }
        static void Main(string[] args)
        {
            Console.Write("Days: ");
            string p = Console.ReadLine();
            int n; int.TryParse(p, out n);
            while (n <= 0)
            {
                Console.Write("Wrong! New value for days: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            double[] arr = new double[n];
            Masiv(arr);
            Console.WriteLine("Average in C is {0}", OutPut(arr, n));
            Console.WriteLine("Average in F is {0}", OutPut_F(arr, n));
            Over(arr);
            Console.WriteLine(Min(arr));
            Console.ReadKey(true);
        }
    }
}
