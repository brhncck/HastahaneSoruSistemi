using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobilFinal
{
    public class SubeDataAcces
    {
        private SQLiteConnection database;


        public SubeDataAcces()
        {
            var dbName = "HastahaneYonetimSistemi.db3";

            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);

            database = new SQLiteConnection(path);

            database.CreateTable<SubeYonetimSistemi>();



        }
        public void AddNewHastahaneYonetimSistemi(MobilFinal.Model.Sube sube)
        {
            SubeYonetimSistemi deneme = new SubeYonetimSistemi();
            deneme.Hastahe = sube.H_kod;
            deneme.SubeAdı = sube.S_ad;
            deneme.SubeKodu = sube.S_kod;
            


            database.Insert(deneme);
        }

        public List<SubeYonetimSistemi> GetFilteredHastahaneYonetimSistemi()
        {
            return database.Query<SubeYonetimSistemi>
                     ("SELECT * FROM SoruYonetimSistemi").ToList();
        }
    }
}
