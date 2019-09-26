using System;
using System.Collections.Generic;
using System.Text;

namespace MobilFinal.Model
{
   public class Soru
    {

        public int Id { get; set; }

        

        public string Tur;

        public string Soru_ekle { get; set; }

        public string Nesne_kod { get; set; }

        public string Username { get; set; }

        public string Aciklama { get; set; }

        public Soru() { }

        public Soru(string Tur, string Soru_ekle, string Nesne_kod ,string Username, string Aciklama)
        {

           
            this.Tur = Tur;
            this.Soru_ekle = Soru_ekle;
            this.Nesne_kod = Nesne_kod;
            this.Username = Username;
            this.Aciklama = Aciklama;

        }







    }
}
