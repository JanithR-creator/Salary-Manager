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

        public Allowance(Salary salary, double rate) : base(salary)
        {
            this.rate = rate;
        }

        public override double salaryCalculator()
        {
            return salary.salaryCalculator() * rate + salary.salaryCalculator();
        }
    }
}
