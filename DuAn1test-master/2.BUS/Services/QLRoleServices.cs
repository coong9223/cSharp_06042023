using _1.DAL.Entities;
using _1.DAL.iRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLRoleServices : IQLRoleServices
    {
        private IRoleRepositories _iqlRole;
        private List<Role> _lstRole;        
        public QLRoleServices()
        {
            _iqlRole = new RoleRepositories();
            _lstRole = new List<Role>();
        }

        public bool AddRole(Role role)
        {
            _iqlRole.AddRole(role);
            return true;
        }

        public List<Role> GetRoleFromDB()
        {
            _lstRole = _iqlRole.GetRoleFromDB();
            return _lstRole;
        }
    }
}
