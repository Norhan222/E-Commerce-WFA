using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application
{
    public class UserSession
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public string Role { get; set; }


    }
    public static class SessionManger
    {
        public static UserSession currentUser { get; set; }
    }
}
