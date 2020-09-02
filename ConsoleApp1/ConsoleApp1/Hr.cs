using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Hr : Employee
    {
        public int bonous;
        public int commission;

        public void display()
        {
            Console.WriteLine("Enter the Bonous and Commission");
            bonous = Convert.ToInt32(Console.ReadLine());
            commission = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("bonous is "+bonous);
            Console.WriteLine("commission is " + commission);
        }
    }
   
}
