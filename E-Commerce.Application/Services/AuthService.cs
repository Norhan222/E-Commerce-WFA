using E_Commerce.Application.Dtos;
using E_Commerce.Application.Interfaces;
using E_Commerce.Core.Entites;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepo _userRepo;

        public AuthService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public async Task<bool> Login(LoginDto userDto)
        {
            var user = await _userRepo.GetByUsernameAsync(userDto.Username);
            if(user != null)
            {
               var paashshd=HashPassword(userDto.Password);
                if(paashshd == user.Password)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public async Task Register(RegisterDto userDto)
        {
            var user=await _userRepo.GetByUsernameAsync(userDto.UserName);
            if(user != null)
            {
                return;
            }
            var usermapped = userDto.Adapt<User>();
            usermapped.Password=HashPassword(userDto.Password);
           await _userRepo.AddUserAsync(usermapped);
        }


        private string HashPassword(string password)
        {
            using(SHA256 sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Encoding.UTF8.GetString(bytes);
            }
        }
    }
}
