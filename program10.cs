using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class program10
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int n;
            Console.WriteLine("enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(" ");
            }

            Console.ReadLine();
        }
    }
}
