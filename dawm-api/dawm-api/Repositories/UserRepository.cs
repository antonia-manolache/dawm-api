using dawm_api.Entities;
using dawm_api.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using static dawm_api.AppDbContext;

namespace dawm_api.Repositories
{
    public class PostRepository : IUserRepository
    {
        public PostRepository()
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

        public User GetUserById(int userId)
        {
            using (var context = new AppDbContext())
            {
                var result = context.Users
                .Where(e => e.Id == userId)
                .FirstOrDefault();

                return result;
            }
        }

        public Post GetPostById(int postId)
        {
            using (var context = new AppDbContext())
            {
                var result = context.Posts
                .Where(e => e.Id == postId)
                .FirstOrDefault();

                return result;
            }
        }

        public List<Post> GetPostsByUserId(int userId)
        {
            using (var context = new AppDbContext())
            {
                var list = context.Posts
                .Where(e => e.Id == userId)
                .ToList();

                return list;
            }
        }
    }
}

