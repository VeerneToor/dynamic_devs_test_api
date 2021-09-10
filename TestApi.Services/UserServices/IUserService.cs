using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Model;

namespace TestApi.Services.UserServices
{

    public interface IUserService 
    {

        public UserModel GetUserById(int id);
        
    }
}
