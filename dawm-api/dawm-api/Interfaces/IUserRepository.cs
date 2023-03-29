using dawm_api.Entities;

namespace dawm_api.Interfaces
{
    public interface IUserRepository
    {
        public User GetUserById(int id);

        public Post GetPostById(int id);
        public List<User> GetUsers();
        public List<Post> GetPostsByUserId(int userId);
    }
}
