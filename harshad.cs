﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.second_test
{
    public class harshad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int count=0;
            int sum = 0;
            int temp = n;


            while(n>0)
            {
                int rem = n % 10;
                count++;
                sum = sum + rem;
                n = n / 10;
            }
            if(temp%sum==0)
            {
                Console.WriteLine("harshad number:");
            }
            else
            {
                Console.WriteLine("not harshad number ");
            }
        }
    }
}
