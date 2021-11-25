using MyBlog.Domain.Entites;
using MyBlog.Domain.Repositories;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(string ConString)
        {
            this.ConString = ConString;
        }

        public string ConString { get; }

        public async Task<User> Login(string username)
        {
            User user = null;
            using (NpgsqlConnection conn = new NpgsqlConnection(ConString))
            {
                await conn.OpenAsync();
                var comtext = "select * from Users where username = @username";
                using (NpgsqlCommand comm = new NpgsqlCommand(comtext,conn))
                {
                    comm.Parameters.AddWithValue("@username", username);
                    var reader = await comm.ExecuteReaderAsync();
                    if (reader.Read())
                    {
                        user = new User()
                        {
                            Username = username,
                            Password = (string)reader["password"]
                        };
                    }
                }
            }
            return user;
        }
    }
}
