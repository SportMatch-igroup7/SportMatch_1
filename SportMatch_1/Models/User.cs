using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportMatch_1.Models
{
    public class User
    {
        int code;
        string email;
        string password;
        string type;

        public int Code { get => code; set => code = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }

        public User() { }

        public User(string email1, string pass)
        {
            Email = email1;
            Password = pass;
        }

        public User(int code1,string email1, string pass, string type1)
        {
            Code = code1;
            Email = email1;
            Password = pass;
            Type = type1;
        }

        public List<User> getUsers(string email)
        {
            DBservices dbs = new DBservices();
            List<User> arrUsers = dbs.getUsers(email);
            return arrUsers;
        }
    }
}