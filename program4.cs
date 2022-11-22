using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class program4
    {
        static void Main(string[] args)
        {
            int a=10;
            int b=20;
            int c=30;
            if (a >= b && a >= c)
            {
                Console.WriteLine("A is large");
            }
            else if(b>=c)
            {
                Console.WriteLine("B is large");
            }
            else
            {
                Console.WriteLine("C is large");
            }
            Console.ReadLine();
        }
    }
}
