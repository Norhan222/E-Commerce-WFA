using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Interfaces
{
    public interface IUserRepo
    {
        public  Task<User> GetByUsernameAsync(string username);
        public Task<string> AddUserAsync(User user);
    }
}
