using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Interfaces
{
    internal interface IUserRepo
    {
        public  Task<User> GetByIdAsync(int id);
        public Task<string> AddUserAsync(User user);
    }
}
