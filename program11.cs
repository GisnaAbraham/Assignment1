using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class program11
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int n3;
            int sum = 0;
            float per;
            int max;
            Console.WriteLine("enter 1st mark");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd mark");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 3rd mark");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter maximum mark");
            max = Convert.ToInt32(Console.ReadLine());
            sum = n1 + n2 + n3;
            per = (sum / max)*100;
            Console.WriteLine("percentage=" + per);
            Console.ReadLine();


        }
    }
}
