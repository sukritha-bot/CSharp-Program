using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Employee
    {
        public int id;
        public string name;
        public float sal;

        public void insert()
        {
            Console.Write("Enter the Id, Name and Salary");
            id = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Id is " + id + " name is " + name + " Salary is " + sal);
        }

    }
}
