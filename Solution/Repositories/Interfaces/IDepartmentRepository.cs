using System;
using System.Collections.Generic;
using System.Text;
using InterviewTestTemplatev2.Data;

namespace SynetecRepositories.Factory.Interfaces
{
    interface IDepartmentRepository
    {
        List<HrDepartment> GetAll();
        HrDepartment Get(int id);
        //Can add Save, Update, delete functions for Department
    }
}
