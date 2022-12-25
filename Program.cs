using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prefect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1, n2;
            Console.WriteLine("enter the first number");
            int firstnum = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int secondnum = int.Parse(Console.ReadLine());
            Console.WriteLine("the prefect numbers between {0} and {1} are:", firstnum, secondnum);
            for (int i = firstnum; i <= secondnum; i++)
            {
                if (isperfect(i))
                {
                    Console.WriteLine(i);
                }
            }



        }

        static bool isperfect(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum == n;
        }
    }
}
