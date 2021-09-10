using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Model;

namespace TestApi.Data.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        public UserModel CreateUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public UserModel DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel GetUserByAge(int age)
        {
            throw new NotImplementedException();
        }

        public UserModel GetUserById(int id)
        {
            return new UserModel {
                FullName = "Harold Castro",
                Dni = "1006453517",
                Age = id,
            };
        }

        public UserModel GetUsers()
        {
            throw new NotImplementedException();
        }

        public UserModel UpdateUser(UserModel newUser)
        {
            throw new NotImplementedException();
        }
    }
}
