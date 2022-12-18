using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the start");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the end");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine(" the perfect numbers are : ");

            for (int i = start; i <= end; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum = sum + j;
                }
                if (i == 0) continue;
                if (sum == i)
                    Console.WriteLine(i);
            }


        }
    }
}
