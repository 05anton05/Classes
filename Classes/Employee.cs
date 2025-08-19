using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Employee
    {
        public string name { get; set; }
        public string position { get; set; }
        public double salary { get; set; }
        private int _workDays;
        public int workDays
        {
            get { return _workDays; }
            set { _workDays = value; }
        }
        public void AddWorkDays(int days = 1)
        {
            if (days < 20)
            {
               workDays += days + 9;
            }
        }
        public void PrintSummary()
        {
            Console.WriteLine($"\nName: {name}, \nPosition: {position}, \nSalary: {salary}, \nQuantity of work days: {workDays}");
        }

    }
}
