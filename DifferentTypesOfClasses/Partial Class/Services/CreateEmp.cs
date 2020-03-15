using DifferentTypesOfClasses.Partial_Class.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DifferentTypesOfClasses.Partial_Class
{
    public sealed partial class Employee : IEmpRepo
    {
        public void CreateEmp()
        {
            Console.WriteLine("this is save method");
        }
    }
}
