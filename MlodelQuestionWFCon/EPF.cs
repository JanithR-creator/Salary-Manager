using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelQuestion
{
    internal class EPF : SalaryDecorator
    {
        public EPF(Salary salary) : base(salary) { }

        public override double salaryCalculator()
        {
            return salary.salaryCalculator() - salary.salaryCalculator() * 0.05;
        }
    }
}
