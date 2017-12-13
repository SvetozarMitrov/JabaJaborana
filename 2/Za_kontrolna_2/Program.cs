using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Za_kontrolna_2
{
    class Program
    {
        static double Tri(double x, double y, double z)
        {
            double res;
            if (x * z != 0)
            {
                res = (x * y + y * z) / x * z;
            }
            else
                res = 0;
            return res;
        }
        static double Dve(double x, double y)
        {
            double res;
            if (x + y != 0)
                res = x * y / (x + y);
            else
                res = 3;
            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("x= ");
            double x = Convert.ToDouble(Console.ReadLine());
            double z = 0;
            double p = 0;
            if (x<-1)
            {
                z = Tri(x, x / 2, 2 * x);
                p = Dve(x, 2 * x);
                Console.WriteLine("z= " + z);
                Console.WriteLine("p= " + p);
            }
            else if (x>1)
            {
                int br = 0;
                double sum = 0;
                Console.Write("n= ");
                int n = Convert.ToInt32(Console.ReadLine());
                double[] a = new double[n];
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write("a[{0}]= ", i);
                    a[i] = Convert.ToDouble(Console.ReadLine());
                    if (a[i] > x)
                        br++;
                    else
                        sum += a[i];
                }
                Console.WriteLine("Broi= " + br);
                Console.WriteLine("Sumata na elementite <{0} e {1}", x, sum);
            }
            Console.ReadKey(true);
        }
    }
}
