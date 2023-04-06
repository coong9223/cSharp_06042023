using BanGiay_ASP_c4.Models;
using BanGiay_ASP_c4.iServices;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Razor.Infrastructure;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;

namespace BanGiay_ASP_c4.Services
{
    public class UserSer : iUser
    {
        ShopGiayDbContext dbContext;
        public UserSer()
        {
            dbContext = new ShopGiayDbContext();
        }
        public bool createUser(User u)
        {
            try
            {
                dbContext.Users.Add(u);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool deleteUser(Guid id)
        {
            try
            {
                var user = dbContext.Users.Find(id);
                dbContext.Users.Remove(user);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<User> getAllUser()
        {
            return dbContext.Users.ToList();
        }

        public User getById(Guid id)
        {
            return dbContext.Users.FirstOrDefault(v => v.idUser == id);
        }

        public List<User> getByName(string name)
        {
            return dbContext.Users.Where(v => v.nameUser.Contains(name)).ToList();
        }

        public bool updateUser(User u)
        {
            try
            {
                var user = dbContext.Users.Find(u.idUser);
                user.nameUser = u.nameUser;
                user.emailUser = u.emailUser;
                user.passwordUser = u.passwordUser;
                user.statusUser = u.statusUser;
                user.idRole = u.idRole;

                dbContext.Users.Update(user);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
