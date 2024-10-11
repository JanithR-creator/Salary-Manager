using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelQuestion
{
    internal abstract class SalaryDecorator : Salary
    {
        protected Salary salary;

        public SalaryDecorator(Salary salary)
        {
            this.salary = salary;
        }
        public abstract double salaryCalculator();
    }
}
