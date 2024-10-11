using ModelQuestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MlodelQuestionWFCon
{
    internal class SalaryManager
    {
        public SalaryManager()
        {

            foreach (Employee employe in EmployeeData.EmployeeTable)
            {
                Salary salary = new BasicSalary(employe.Basic);

                salary = new Allowance(salary, employe.Rate);

                if (employe.transportState == false)
                {
                    salary = new TransPortAllowance(salary);
                }

                salary = new EPF(salary);

                if (salary.salaryCalculator() > 100000)
                {
                    salary = new IncomeTax(salary);
                }
                Employee emp = new Employee(
                    employe.Name,
                    employe.Position, 
                    employe.Basic, 
                    employe.Rate,
                    employe.transportState, 
                    salary.salaryCalculator()
                    );
                EmployeeData.SalaryTable.Add(emp);
            }
        }
    }
}
