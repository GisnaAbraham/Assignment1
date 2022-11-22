using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class program2
    {
        static void Main(string[] args)
        {
            int n;
            int a = 10;
            int i;
            Console.WriteLine("enter the table multiplication number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= a; i++)
            {
                Console.WriteLine("{0}*{1}={2}",i, n, i * n);
            }
            Console.ReadLine();
        }
    }
}
