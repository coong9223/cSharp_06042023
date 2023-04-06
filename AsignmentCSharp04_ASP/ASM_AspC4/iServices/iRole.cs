using ASM_AspC4.Models;

namespace ASM_AspC4.iServices
{
    public interface iRole
    {
        public bool createRole (Role r);
        public bool deleteRole (Guid id);
        public bool updateRole (Role r);
        public List<Role> getALlRole ();
        public Role getById(Guid id);
        public List<Role> getByName (string name);
    }
}
