using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelQuestion
{
    internal class Employee
    {
        public Employee(String name, String position, double basic, double rate, bool state)
        {
            this.Name = name;
            this.Position = position;
            this.Basic = basic;
            this.Rate = rate;
            this.transportState = state;
        }

        public Employee(String name, String position, double basic, double rate, bool state, double salary)
        {
            this.Name = name;
            this.Position = position;
            this.Basic = basic;
            this.Rate = rate;
            this.transportState = state;
            this.NetSalary = salary;
        }

        public Employee(double salary)
        {
            this.NetSalary = salary;
        }

        public String Name { get; set; }
        public String Position { get; set; }
        public double Basic { get; set; }
        public double Rate { get; set; }
        public bool transportState { get; set; }

        public double NetSalary {  get; set; }
    }
}
