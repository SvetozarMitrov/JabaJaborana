using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_Titeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int x = -13; x <= 13; x++)
            {
                for (int y = -16; y <= 16; y++)
                {
                    double res = Math.Pow(x, 2) / 169 + Math.Pow(y, 2) / 256;
                    if (res < 1)
                    {
                        Console.WriteLine("A[{0},{1}]", x, y);
                        count++;
                    }
                }
            }
            Console.WriteLine("Count is " + count);
            Console.ReadKey(true);
        }
    }
}
