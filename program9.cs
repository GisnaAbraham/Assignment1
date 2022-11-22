using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class program9
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int n;
            int k=0;
            Console.WriteLine("enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = n; i >= 1; i--)
            {
                for (j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < (i * 2); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
