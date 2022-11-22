using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class program8
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int n;
            int k;
            Console.WriteLine("enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                for (j = 1; j <= (n-i); j++)
                {
                        Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");  
                }
                for(k=(i-1);k>=1;k--)
                Console.Write("*");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

