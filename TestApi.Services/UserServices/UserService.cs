using TestApi.Model;
using TestApi.Data.Repositories;

namespace TestApi.Services.UserServices
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public UserModel GetUserById(int id)
        {
            return _repository.GetUserById(id);
        }


    }
}
