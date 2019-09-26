using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobilFinal
{
    public class UserDataAcces
    {
        private SQLiteConnection database;


        public UserDataAcces()
        {
            var dbName = "HastahaneYonetimSistemi.db3";

            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);

            database = new SQLiteConnection(path);

            database.CreateTable<UserYonetimSistemi>();


        }
        public void AddNewHastahaneYonetimSistemi(MobilFinal.Model.User user)
        {
            UserYonetimSistemi deneme = new UserYonetimSistemi();
            deneme.Username = user.Username;
            deneme.Password = user.Password;
            deneme.SubeKod = user.S_kod;
            deneme.Unvan = user.Unvan;


            database.Insert(deneme);
        }

        public List<UserYonetimSistemi> GetFilteredHastahaneYonetimSistemi()
        {
            return database.Query<UserYonetimSistemi>
                     ("SELECT * FROM UserYonetimSistemi").ToList();
        }
    }
}
