using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HubCollege.model
{
    public class Login
    {
        public int Id { get; set; }

        public string RegistrationNumber { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }

        public Login() { }

        // toRegister
        public Login(string registrationNumber, string userEmail, string password)
        {
            RegistrationNumber = registrationNumber;
            UserEmail = userEmail;
            Password = password;
        }
        
        // toForms
        public Login(string registrationNumber, string password)
        {
            RegistrationNumber = registrationNumber;
            Password = password;
        }
    }
}