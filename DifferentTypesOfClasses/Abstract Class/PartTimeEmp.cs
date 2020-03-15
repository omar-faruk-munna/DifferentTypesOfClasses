using System;
using System.Collections.Generic;
using System.Text;

namespace DifferentTypesOfClasses.Abstract_Class
{
    public class PartTimeEmp : BaseEmp
    {
        public int HourlyPay { get; set; }
        public int TotalHours { get; set; }

        public override int GetMonthlySalary()
        {
            return this.HourlyPay * this.TotalHours;
        }
    }
}
