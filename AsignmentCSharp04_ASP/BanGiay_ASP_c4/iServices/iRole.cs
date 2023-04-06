using BanGiay_ASP_c4.Models;

namespace BanGiay_ASP_c4.iServices
{
    public interface iRole
    {
        public bool createRole(Role r);
        public bool deleteRole(Guid id);
        public bool updateRole(Role r);
        public List<Role> getALlRole();
        public Role getById(Guid id);
        public List<Role> getByName(string name);
    }
}
