using System.Collections.Generic;
using System.Linq;

using MVC6_ViewDependencyInjection.Models;

namespace MVC6_ViewDependencyInjection.Services
{
    public class DalService
    {
        EmployeeDatabase db;

        public DalService()
        {
            db = new EmployeeDatabase();
        }

        public IEnumerable<Employee> Get()
        {
            return db;
        }

        public int GetManagerCount()
        {
            var Res = (from e in db
                       where e.Designation == "Manager"
                       select e);
            return Res.Count();
        }
        public int GetLeadCount()
        {
            var Res = (from e in db
                       where e.Designation == "Lead"
                       select e);
            return Res.Count();
        }
        public int GetClerkCount()
        {
            var Res = (from e in db
                       where e.Designation == "Clerk"
                       select e);
            return Res.Count();
        }
    }
}