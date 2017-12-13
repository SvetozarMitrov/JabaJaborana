using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_404
{
    class Program
    {
        static int Sum(int[] arr, int k)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > k)
                    sum = sum + arr[i];
            }
            return sum;
        }
        static int Prod(int[] arr, int k)
        {
            int pr = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    continue;
                else if (arr[i] < k)
                    pr = pr * arr[i];
            }
            return pr;
        }
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n < 2 || n > 50)
            {
                Console.Write("new value for n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}]= ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("k= ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum is " + Sum(arr, k));
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] / 100 >= 1 && arr[i] / 100 <= 9)
                {
                    int st = arr[i] / 100;
                    int val = arr[i] % 100;
                    int des = val / 10;
                    int ed = val % 10;
                    int sum = st + des + ed;
                    if (sum % 2 == 0)
                        count++;
                }
            }
      
            int br = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 100 && arr[i] <= 666)
                {
                    int st = arr[i] / 100;
                    int val = arr[i] % 100;
                    int des = val / 10;
                    int ed = val % 10;
                    int sum2 = st + des + ed;
                    if (sum2 % 3 == 0)
                        br++;
                }
            }
            Console.WriteLine("Count is " + count);
            Console.WriteLine("Production is " + Prod(arr, k));
            Console.WriteLine("Broy is " + br);
            Console.ReadKey(true);
        }
    }
}
