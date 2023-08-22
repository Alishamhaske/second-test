using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.second_test
{
    public class methodoverload
    {
        static void Main(string[] args)
        {
            areas a1 = new areas();
            Console.WriteLine(a1.area(6));
            Console.WriteLine(a1.area(8.3));
            Console.WriteLine(a1.area(6,8));
            Console.WriteLine(a1.area(7.7,43));

        }
    }

    //overload method calculate area circle , square, reactangle, triangle

    public class areas
    {
       public double A;

        public string area(int r)
        {
            double cir_area = (3.14 * r * r);
            return $"area of circel:{cir_area}";
        }

        public string area(double a)
        {
            double squ_area = a*a;
            return $"area of square:{squ_area}";
        }

        public string area(int l,int b)
        {
            double rect_area = l*b;
            return $"area of reactangle:{rect_area}";
        }

        public string area(double b,double h)
        {
            double tri_area = (0.5*(b*h));
            return $"area of triangle:{tri_area}";
        }





    }
}
