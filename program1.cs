using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class program1
    {
        static void Main(string[] args)
        {
            int a;
            int r;
             int sum=0;
            Console.WriteLine("Enter the number");
            a = Convert.ToInt32(Console.ReadLine());
            while(a>0)
            {
                r = a % 10;
                sum = sum + r;
                a = a / 10;

            }
            Console.WriteLine("sum of digits" + sum);
            Console.ReadLine();
        }
    }
}
