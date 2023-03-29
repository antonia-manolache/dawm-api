using dawm_api.Entities;
using dawm_api.Interfaces;
using System;
using static dawm_api.AppDbContext;

namespace dawm_api.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
            using (var context = new AppDbContext())
            {
                var users = new List<User>
                {
                new User
                {
                    FirstName = "Luke",
                    LastName = "Skywalker",
                       Posts = new List<Post>()
                    {
                        new Post { Content = "Merry Christmas!"},
                        new Post { Content = "Happy Easter!"},
                        new Post { Content = "Happy 4th of July!"}
                    }
                },
                new User
                {
                    FirstName ="David",
                    LastName ="Jones",
                    Posts = new List<Post>()
                    {
                        new Post { Content = "Happy New Year!"},
                        new Post { Content = "Happy Birthday!"},
                        new Post { Content = "Congratulations!"}
                    }
                }
                };

                context.Users.AddRange(users);
                context.SaveChanges();
            }
        }
        public List<User> GetUsers()
        {
            using (var context = new AppDbContext())
            {
                var list = context.Users
                    .Include(a => a.Posts)
                    .ToList();
                return list;
            }
        }
    }
}

