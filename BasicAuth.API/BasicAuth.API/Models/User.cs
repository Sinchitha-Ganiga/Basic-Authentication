using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuth.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
        public string Email { get; set; }

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>()
            {
            new User{Id=1001,UserName="NormalUser",Password="12345",Roles="User",Email="user@email.com" }, //Encoded Credentials - Tm9ybWFsVXNlcjoxMjM0NQ==
            new User{Id=1001,UserName="AdminUser",Password="12345",Roles="Admin",Email="user@email.com" }, //Encoded Credentials - QWRtaW5Vc2VyOjEyMzQ1
            new User{Id=1001,UserName="SuperAdminUser",Password="12345",Roles="SuperAdmin",Email="user@email.com" }, //Encoded Credentials - U3VwZXJBZG1pblVzZXI6MTIzNDU=
            };
            return users;
        }
    }
}