using TestApi.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestApi.Data.Repositories
{
    public interface IUserRepository
    {
        public UserModel CreateUser(UserModel user);

        public UserModel DeleteUser(int id);

        public UserModel UpdateUser(UserModel newUser);

        public UserModel GetUsers();

        public UserModel GetUserById(int id);

        public UserModel GetUserByAge(int age);
    }
}
