using BanGiay_ASP_c4.Models;
using BanGiay_ASP_c4.iServices;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Razor.Infrastructure;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;

namespace BanGiay_ASP_c4.Services
{
    public class RoleSer : iRole
    {

        ShopGiayDbContext dbContext;
        public RoleSer()
        {
            dbContext = new ShopGiayDbContext();    
        }
        public bool createRole(Role r)
        {
            try
            {
                dbContext.Roles.Add(r);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool deleteRole(Guid id)
        {
            try
            {
                var role = dbContext.Roles.Find(id);
                dbContext.Roles.Remove(role);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Role> getALlRole()
        {
            return dbContext.Roles.ToList();
        }

        public Role getById(Guid id)
        {
            return dbContext.Roles.FirstOrDefault(v => v.idRole == id);
        }

        public List<Role> getByName(string name)
        {
            return dbContext.Roles.Where(v => v.nameRole.Contains(name)).ToList();
        }

        public bool updateRole(Role r)
        {
            try
            {
                var role = dbContext.Roles.Find(r.idRole);
                role.nameRole = r.nameRole;
                role.statusRole = r.statusRole;
                dbContext.Roles.Update(role);
                dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
