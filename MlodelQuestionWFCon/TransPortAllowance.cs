using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelQuestion
{
    internal class TransPortAllowance : SalaryDecorator
    {
        public TransPortAllowance(Salary salary) : base(salary) { }

        public override double salaryCalculator()
        {
            return salary.salaryCalculator() + 10000.00;
        }
    }
}
