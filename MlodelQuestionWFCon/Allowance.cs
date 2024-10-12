using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelQuestion
{
    internal class Allowance : SalaryDecorator
    {
        private double rate;
        private double basic;

        public Allowance(Salary salary, double rate, double basic) : base(salary)
        {
            this.rate = rate;
            this.basic=basic;
        }

        public override double salaryCalculator()
        {
            return new BasicSalary(basic).salaryCalculator() * rate + salary.salaryCalculator();
        }
    }
}
