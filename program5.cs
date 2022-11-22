using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class program5
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter the number");
            a = Convert.ToInt32(Console.ReadLine());
            if(a>0)
            {
                Console.WriteLine("positive number");
            }
            else if(a<0)
            {
                Console.WriteLine("negative number");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
            Console.ReadLine();
        }
    }
}
