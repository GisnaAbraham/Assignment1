using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class program3
    {
        static void Main(string[] args)
        {
            int i;
            int sum=0;
            Console.WriteLine("sum of 10 natural numbers");
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("sum=" + sum);
            Console.ReadLine();
        }
    }
}
