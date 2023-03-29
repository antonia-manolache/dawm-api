using dawm_api.Entities;

namespace dawm_api.Interfaces
{
    public interface IUserRepository
    {
        public List<User> GetUsers();
    }
}
