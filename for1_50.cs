using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.second_test
{
    public class for1_50
    {
        //display number 1 to 50 if number is even than display square and odd number display negative
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    int s = i * i;
                    Console.WriteLine(s);
                }
                else
                {
                   
                    Console.WriteLine(-i);
                }
            }
        }
    }
}
