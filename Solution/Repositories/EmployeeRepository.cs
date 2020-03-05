using InterviewTestTemplatev2.Data;
using SynetecRepositories.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynetecRepositories.Factory
{
    class EmployeeRepository : IEmployeeRepository
    {
        public List<HrEmployee> GetAll()
        {
            return db
        }

        public HrEmployee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public int GetTotalCompanySalary()
        {
            throw new NotImplementedException();
        }
    }
}
