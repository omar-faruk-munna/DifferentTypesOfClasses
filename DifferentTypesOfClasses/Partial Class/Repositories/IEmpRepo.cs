using System;
using System.Collections.Generic;
using System.Text;

namespace DifferentTypesOfClasses.Partial_Class.Repositories
{
    public interface IEmpRepo
    {
        void CreateEmp();
        string ReadEmp();
        void UpdateEmp();
        void DeleteEmp();
    }
}
