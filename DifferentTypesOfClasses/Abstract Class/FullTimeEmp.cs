using System;
using System.Collections.Generic;
using System.Text;

namespace DifferentTypesOfClasses.Abstract_Class
{
    public class FullTimeEmp : BaseEmp
    {
        public int AnnualSalary { get; set; }

        public override int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }
    }
}
