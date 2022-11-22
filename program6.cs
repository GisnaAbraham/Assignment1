using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class program6
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("enter 1st number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("the numbers are same");
            }
            else
            {
                Console.WriteLine("the numbers are not same");
            }
            Console.ReadLine();
        }
    }
}
