using DifferentTypesOfClasses.Partial_Class.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DifferentTypesOfClasses.Partial_Class
{
    public class EmpController
    {
        private IEmpRepo _empRepo;
        public EmpController(IEmpRepo empRepo)
        {
            this._empRepo = empRepo;
        }

        public void MyEmp()
        {
            _empRepo.CreateEmp();
            _empRepo.ReadEmp();
            _empRepo.UpdateEmp();
            _empRepo.DeleteEmp();




        }




    }
}
