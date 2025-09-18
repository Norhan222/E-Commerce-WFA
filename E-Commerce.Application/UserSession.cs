using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application
{
    public struct UserSession
    {
        public int Id { get; set; } = 0;
        public string Username { get; set; } = null;

        public string Role { get; set; } = null;

       public UserSession()
        {

        }

    }
    public static class SessionManger
    {
        public static UserSession currentUser { get; set; }
    }
}
