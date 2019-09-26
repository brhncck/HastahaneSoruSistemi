using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MobilFinal
{
    public class SoruDataAcces
    {
        private SQLiteConnection database;


        public SoruDataAcces()
        {
            var dbName = "HastahaneYonetimSistemi.db3";

            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);

            database = new SQLiteConnection(path);

            database.CreateTable<SoruYonetimSistemi>();



        }
        public void AddNewHastahaneYonetimSistemi(MobilFinal.Model.Soru soru)
        {
            SoruYonetimSistemi deneme = new SoruYonetimSistemi();
            deneme.Tur = soru.Tur;
            deneme.Soru_ekle = soru.Soru_ekle;
            deneme.Nesne_kod = soru.Nesne_kod;
            deneme.Username = soru.Username;
            deneme.Aciklama = soru.Aciklama;
            

            database.Insert(deneme);
        }

        public List<SoruYonetimSistemi> GetFilteredHastahaneYonetimSistemi(string Username)
        {
            
            return database.Query<SoruYonetimSistemi>
                     ("SELECT * FROM SoruYonetimSistemi where Username='"+Username+"'").ToList();
        }
    }
}
