using E_Commerce.Application.Dtos;
using E_Commerce.Application.Interfaces;
using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Services
{
    internal class AuthService : IAuthService
    {
        public Task<bool> Login(LoginDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task Register(RegisterDto userDto)
        {
            
        }
    }
}
