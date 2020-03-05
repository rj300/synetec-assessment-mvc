using InterviewTestTemplatev2.Data;
using SynetecRepositories.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynetecRepositories.Factory
{
    public class DepartmentRepository : IDepartmentRepository
    {
        MvcInterviewV3Entities1 db = new MvcInterviewV3Entities1();
        public HrDepartment Get(int id)
        {
            return (HrDepartment)db.HrDepartments.
        }

        public List<HrDepartment> GetAll()
        {
            return db.HrDepartments.ToList();
        }
    }
}
