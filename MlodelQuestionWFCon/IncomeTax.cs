using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelQuestion
{
    internal class IncomeTax : SalaryDecorator
    {
        public IncomeTax(Salary salary) : base(salary)
        {

        }

        public override double salaryCalculator()
        {
            return salary.salaryCalculator() - salary.salaryCalculator() * 0.1;
        }
    }
}
