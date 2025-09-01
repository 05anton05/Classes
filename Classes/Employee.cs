using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Employee
    {
        private int _workDays;
        

        public string Name { get; set; }

        public string Position { get; set; }

        public double Salary { get; set; }

        public Employee(string name, string position, double salary, int workDays = 5 )
        {
            Name = name;
            Position = position;
            Salary = salary;
            _workDays = workDays; 
        }

        public void AddWorkDays(int days = 1)
        {
            if (days < 20)
            {
               _workDays += days + 9;
            }
            
        }

        public void PrintSummary()
        {
            Console.WriteLine($"\nName: {Name}, \nPosition: {Position}, \nSalary: {Salary}, \nQuantity of work days: {_workDays}");
        }

    }
}
