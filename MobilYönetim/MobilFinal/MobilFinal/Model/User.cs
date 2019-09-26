using System;
using System.Collections.Generic;
using System.Text;

namespace MobilFinal.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Unvan { get; set; }
        public string S_kod { get; set; }
        public User() { }
        public User(string Username, string Password,string Unvan,string S_kod)
        {

            this.Username = Username;
            this.Password = Password;
            this.Unvan = Unvan;
            this.S_kod = S_kod;

        }

       

    }
}
