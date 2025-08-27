using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Employee
    {
        public string Name { get; set; }

        public string Position { get; set; }

        public double Salary { get; set; }

        private int _workDays;

        public int WorkDays
        {
            get { return _workDays; }

            set { _workDays = value; }
        }
        public void AddWorkDays(int days = 1)
        {
            if (days < 20)
            {
               WorkDays += days + 9;
            }
        }
        public void PrintSummary()
        {
            Console.WriteLine($"\nName: {Name}, \nPosition: {Position}, \nSalary: {Salary}, \nQuantity of work days: {WorkDays}");
        }

    }
}
