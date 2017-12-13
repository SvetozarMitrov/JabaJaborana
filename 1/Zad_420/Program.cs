using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_420
{
    class Program
    {
        static double Nj(double x, double y)
        {
            double sum = Math.Pow(x, 2) + Math.Pow(y, 2);
            return sum;
        }
        static double Co(double x, double y)
        {
            double sum = Math.Pow(x, 1.0 / 3) + Math.Pow(y, 1.0 / 3);
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("x= ");
            double x = Convert.ToDouble(Console.ReadLine());
            double z = 0;
            double z2 = 0;
            if (x <= -1)
            {
                Console.Write("y= ");
                double y = Convert.ToDouble(Console.ReadLine());
                while (y < 0)
                {
                    Console.Write("new y: ");
                    y = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("Sumata e " + Nj(x, y));
                Console.WriteLine("Sumata_2 e " + Co(x, y));
            }

            else if (x > 1)
            {
                Console.Write("n= ");
                int n = Convert.ToInt32(Console.ReadLine());
                double[] a = new double[n + 1];
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write("a[{0}]= ", i);
                    a[i] = Convert.ToDouble(Console.ReadLine());
                    z = i * (i - 1) * a[i] * Math.Pow(x, i - 2) + z;
                }
                for (int i = 0; i < a.Length; i++)
                {
                   z2 = z2 + i * (i - 1) * (i - 2) * a[i] * Math.Pow(x, i - 3);
                }
                Console.WriteLine("z= " + z);
                Console.WriteLine("z2= " + z2);
            }
            Console.ReadKey(true);
        }
    }
}
