using System;
using System.Collections;
using System.Collections.Generic;

namespace oop_jan_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Employee/Manager Inheritance and Polymorphism Example */
            var quinton = new Employee("Quinton", "Bolt", 20);
            var will = new Employee("Will", "Marttala", 20);
            
            Employee yolanda = new Manager("Yolanda", "Thompspon", 21, new[] { quinton, will });
            Employee[] employees = { quinton, will, yolanda };

            foreach (Employee e in employees)
            {
                Console.WriteLine("Hey " + e.FirstName);

                if (e is Manager)
                {
                    Console.WriteLine("Hey - you're important");
                }

                Console.WriteLine("------------");
            }

            /* Abstract classes and interfaces */
            IShape s = new Square(5);
            s.Draw();
            
            /* Operator overloading */
            Line l1 = new Line(2);
            Line l2 = new Line(5);
            Line bigLine = l1 + l2;
            Console.WriteLine(bigLine.Length);

        }
    }
}