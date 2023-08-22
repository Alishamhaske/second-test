using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.second_test
{
    public class construtoroverload
    {
        static void Main(string[] args)
        {
            overloadconst c1 = new overloadconst();
            overloadconst c2 = new overloadconst(2,8);
            overloadconst c3 = new overloadconst(7,9,7);

        }

    }


    //constructor overloading

    public class overloadconst
    {
        public int a = 10;
        public int b = 20;
        public double c;
        
        public  overloadconst()
        {
            c = a + b;
            Console.WriteLine(c);
        }
        public overloadconst(int p,int q)
        {
            c =  p+ q;
            Console.WriteLine(c);
        }

        public overloadconst(double x, double y,double z)
        {
            c = x + y+z;
            Console.WriteLine(c);
        }



    }
}
