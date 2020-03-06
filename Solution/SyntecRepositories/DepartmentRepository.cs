using SynetecRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SynetecRepositories.Interfaces;
using SynetecDatabase.Data;

namespace SynetecRepositories
{
    public class DepartmentRepository : BaseRepository, IDepartmentRepository
    {

        public HrDepartment Get(int id)
        {
            return db.HrDepartments.FirstOrDefault(item => item.ID == id);
        }

        public List<HrDepartment> GetAll()
        {
            return db.HrDepartments.ToList();
        }
    }
}
