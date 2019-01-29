using System.Linq;

namespace oop_jan_2019
{
    public class Manager : Employee
    {
        public Employee[] Underlings { get; private set; }
        
        public Manager(string firstName, string lastName, double salary) 
            : base(firstName, lastName, salary)
        {
            Underlings = new Employee[] { };
        }

        public Manager(string firstName, string lastName, double salary, Employee[] underlings) 
            : base(firstName, lastName, salary)
        {
            Underlings = underlings;
        }

        public void Fire(int id)
        {
            // Create a new array without the given employee based on Id
            Underlings = Underlings.Where(x => x.Id != id).ToArray();
        }

        public void Hire(Employee e)
        {
            // Create a new array with the employee concatenated
            Underlings = Underlings.Concat(new[] {e}).ToArray();
        }
    }
}