using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Za_kontrolna
{
    class Program
    {
        static int[] Masiv()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            while(n<2 || n>30)
            {
                Console.Write("new n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}]= ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        static double Sredno(int[] a, int k)
        {
            
            double sum = 0;
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= -k && a[i] <= k && a[i] % 5 == 0)
                    sum += a[i]; count++;
            }
            double average = sum / count;
            return average;
        }
        static int Last_Min(int[] arr)
        {
            int min = arr[0];
            int ind = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i]; 
                
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == min)
                    ind = i;
            }
            return ind;
        }
        static void Main(string[] args)
        {
            int[] arr = Masiv();
            Console.Write("k= ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The average of the elemnts which are in the interval [-{0}, {1}] and %5==0 is {2:F2}", k, k, Sredno(arr, k));
            int index = Last_Min(arr);
            Console.WriteLine("The last minimal element is {0} with index {1}", arr[index], index);
            Console.ReadKey(true);
        }
    }
}
