using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HubCollege.model
{
    public class Login
    {
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }

        public Login() { }
        public Login(string userEmail, string password)
        {
            UserEmail = userEmail;
            Password = password;
        }
    }
}