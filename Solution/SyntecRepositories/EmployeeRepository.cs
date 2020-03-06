using SynetecRepositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using SynetecDatabase.Data;

namespace SynetecRepositories
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public HrEmployee Get(int Id)
        {
            return db.HrEmployees.FirstOrDefault(item => item.ID == Id);
        }

        public List<HrEmployee> GetAll()
        {
            return db.HrEmployees.ToList();
        }
        
    }
}
