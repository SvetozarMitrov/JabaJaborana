using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_416
{
    class Program
    {
        static double Max(double x, double y)
        {
            double max = x;
            if (max < y)
                max = y;
            return max;
        }
        static double Ty(double x, double y)
        {
            double sum = Math.Sqrt(Math.Abs(x)) + Math.Sqrt(Math.Abs(y));
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("x= ");
            double x = Convert.ToDouble(Console.ReadLine());
            
            double z = 0;
            if (x < -1)
            {
                Console.Write("y= ");
                double y = Convert.ToDouble(Console.ReadLine());
                while (y > 0)
                {
                    Console.Write("new value for y: ");
                    y = Convert.ToDouble(Console.ReadLine());
                }
                //z = Max(x, y);
                z = Ty(x, y);
            }
            //else if (x >= -5 && x <= 5)
            //    z = 0;
            //else
            //{
            //    Console.Write("n= ");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    double[] a = new double[n+1];
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        Console.Write("a[{0}]= ", i);
            //        a[i] = Convert.ToDouble(Console.ReadLine());
            //        z = z + a[i] * Math.Pow(x, i);
            //    }
                
            //}
            if (x>1)
            {
                Console.Write("n= ");
                int n = Convert.ToInt32(Console.ReadLine());
                double[] a = new double[n + 1];
               
                //for (int i = 0; i < a.Length; i++)
                //{
                //    Console.Write("a[{0}]= ", i);
                //    a[i] = Convert.ToDouble(Console.ReadLine());
                //}
                //for (int i = 3; i < a.Length; i += 3)
                //{
                //    z = z + a[i];
                //}

                //zad_419
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write("a[{0}]= ", i);
                    a[i] = Convert.ToDouble(Console.ReadLine());
                    z = z + i * a[i] * Math.Pow(x, i - 1);
                }

            }
            Console.WriteLine("z= " + z);
            Console.ReadKey(true);
        }
    }
}
