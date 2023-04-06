using _1.DAL.Context;
using _1.DAL.Entities;
using _1.DAL.iRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class RoleRepositories : IRoleRepositories
    {
        private List<Role> _lstRole;
        private DatabaseContext _context;
        public RoleRepositories()
        {
            _context = new DatabaseContext();
            _lstRole = new List<Role>();
        }

        public bool AddRole(Role role)
        {
           _context.Roles.Add(role);
            _context.SaveChanges();
            return true;
        }

        public List<Role> GetRoleFromDB()
        {
            _lstRole = _context.Roles.ToList();
            return _lstRole;
        }
    }
}
