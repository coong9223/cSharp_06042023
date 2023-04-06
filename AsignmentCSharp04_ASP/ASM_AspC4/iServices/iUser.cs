using ASM_AspC4.Models;

namespace ASM_AspC4.iServices
{
    public interface iUser
    {
        public bool createUser(User u);
        public bool updateUser(User u);
        public bool deleteUser(Guid id);
        public List<User> getAllUser();
        public User getById(Guid id);
        public List<User> getByName(string name);
    }
}
