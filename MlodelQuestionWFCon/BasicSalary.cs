using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelQuestion
{
    internal class BasicSalary : Salary
    {
        private String position;
        private double basic;

        public BasicSalary(String position)
        {
            this.position = position;
        }

        public BasicSalary(double basic)
        {
            this.basic = basic;
        }

        public double salaryCalculator()
        {
            /*if (position.ToLower() == "tech lead") 
            {
                return 4000000;
            }else if(position.ToLower() == "intern")
            {
                return 50000;
            }else if(position.ToLower()=="project manager")
            {
                return 300000;
            }else if(position.ToLower()=="senior software developer")
            {
                return 200000;
            }else if(position.ToLower()=="assosiate tech lead")
            {
                return 320000;
            }
            else
            {
                return 0;
            }*/

            return basic;
        }
    }
}
