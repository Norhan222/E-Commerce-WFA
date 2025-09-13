using E_Commerce.Application.Interfaces;
using E_Commerce.Core.Entites;
using E_Commerce.Infrastrucrure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastrucrure.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly AppDbContext _dbContext;

        public UserRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<string> AddUserAsync(User user)
        {
           await _dbContext.Users.AddAsync(user);
           int row= await _dbContext.SaveChangesAsync();
            return row.ToString();
        }

        public  async Task<User> GetByUsernameAsync(string username)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.UserName==username);

            return user;
        }
    }
}
