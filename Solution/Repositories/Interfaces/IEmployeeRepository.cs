using InterviewTestTemplatev2.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynetecRepositories.Factory.Interfaces
{
    interface IEmployeeRepository
    {
        List<HrEmployee> GetAll();
        HrEmployee GetEmployee(int id);
        int GetTotalCompanySalary();
    }
}
