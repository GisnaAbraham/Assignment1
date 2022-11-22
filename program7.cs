using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class program7
    {
        static void Main(string[] args)
        {
            int a;
            int sum = 0;
            Console.WriteLine("enter the limit");
            a = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<=a;i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum=" + sum);
            Console.ReadLine();


        }
    
    }
}

