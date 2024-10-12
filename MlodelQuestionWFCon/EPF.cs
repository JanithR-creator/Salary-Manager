using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelQuestion
{
    internal class EPF : SalaryDecorator
    {
        private String position;
        public EPF(Salary salary, String position) : base(salary)
        {
            this.position = position;
        }

        public override double salaryCalculator()
        {
            if (position.ToLower() != "intern")
            {
                return salary.salaryCalculator() - salary.salaryCalculator() * 0.05;
            }
            else
            {
                return salary.salaryCalculator();
            }
            
        }
    }
}
