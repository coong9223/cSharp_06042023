using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.iRepositories
{
    public interface IRoleRepositories
    {
        bool AddRole(Role role);
        List<Role> GetRoleFromDB();
    }
}
