using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MobilFinal
{
    [Table("UserYonetimSistemi")]

    public class UserYonetimSistemi 
    {
        private int _id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;
               

            }
        }
        private string _username;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                this._username = value;
               
            }

        }
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                this._password = value;
                
            }

        }
        private string _unvan;
        public string Unvan
        {
            get
            {
                return _unvan;
            }
            set
            {
                this._unvan = value;
               
            }

        }
        private string _subeKod;
        public string SubeKod
        {
            get
            {
                return _subeKod;
            }
            set
            {
                this._subeKod = value;
               
            }
        }

       
    }

}
