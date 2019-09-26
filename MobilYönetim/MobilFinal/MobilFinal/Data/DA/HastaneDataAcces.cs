using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using MobilFinal.Views;
using System.IO;

namespace MobilFinal
{
    public class HastaneDataAcces
    {
        private SQLiteConnection database;


        public HastaneDataAcces()
        {
            var dbName = "HastahaneYonetimSistemi.db3";

            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);

            database = new SQLiteConnection(path);

            database.CreateTable<HastahaneYonetimSistemi>();

            

        }
        public void AddNewHastahaneYonetimSistemi(MobilFinal.Model.Hastane hastane)
        {
            HastahaneYonetimSistemi deneme = new HastahaneYonetimSistemi();
            deneme.HastaneAdi = hastane.H_ad;

            database.Insert(deneme);
        } 

        public List<HastahaneYonetimSistemi> GetFilteredHastahaneYonetimSistemi()
        {
            return database.Query<HastahaneYonetimSistemi>
                     ("SELECT * FROM HastahaneYonetimSistemi").ToList();
        }
    }
}
