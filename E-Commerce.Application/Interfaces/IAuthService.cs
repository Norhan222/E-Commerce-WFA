using E_Commerce.Application.Dtos;
using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Interfaces
{
    public interface IAuthService
    {
        public Task Register(RegisterDto userDto);
        public Task<bool> Login(LoginDto userDto);
    }
}
