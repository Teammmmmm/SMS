using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electro.Models
{
    public class Users
    {

        public int ID;
        public string Username;
        public string Enail;
        public int Age;
        public string Gender;
        public int BirthDate;
        public int PhoneNumber;
        public string Email { get; set; }
        public string Password { get; set; }



        public static bool log(string Email, string password)
        {
            if (Email == "admin@admin" && password == "admin")
                return true;

            else
                return false;

        }


    }
}
