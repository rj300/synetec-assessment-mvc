using SynetecDatabase.Data;
using System.Collections.Generic;

namespace SynetecRepositories.Interfaces
{
    public interface IDepartmentRepository
    {
        List<HrDepartment> GetAll();
        HrDepartment Get(int id);
        //Can add Save, Update, delete functions for Department
    }
}
