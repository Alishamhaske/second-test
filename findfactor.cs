using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.second_test
{
    public class findfactor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int sum = 0;

            while(n>0)
            {
                int rem = n % 10;
                count++;
                sum = sum + rem;
                n = n / 10;
            }
            int avg = sum / count;
            Console.WriteLine(avg);

        }
    }
}
