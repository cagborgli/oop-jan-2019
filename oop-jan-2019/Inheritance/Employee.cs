using System;

namespace oop_jan_2019
{
    public class Employee
    {
        private static int IdGenerator { get; set; } = 1;
        
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public double Salary { get; }

        public Employee(string firstName, string lastName, double salary)
        {
            Id = IdGenerator++;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: Salary - ${Salary}";
        }

        public override bool Equals(object obj)
        {
            if (obj == this) return true;
            if (obj == null) return false;
            Employee emp = null;
            if (obj is Employee)
            {
                emp = (Employee) obj;
            }

            return emp.Id == Id;
        }
    }
}