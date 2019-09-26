using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MobilFinal
{
    [Table("SoruYonetimSistemi")]

    public class SoruYonetimSistemi
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
        private string _tur;

        public string Tur
        {
            get
            {
                return _tur;
            }
            set
            {
                this._tur = value;
               
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
        private string _soru_ekle;

        public string Soru_ekle
        {
            get
            {
                return _soru_ekle;
            }
            set
            {
                this._soru_ekle = value;
               
            }

        }
        private string _nesne_kod;
        public string Nesne_kod
        {
            get
            {
                return _nesne_kod;
            }
            set
            {
                this._nesne_kod = value;
               
            }

        }
        private string _aciklama;
        public string Aciklama
        {
            get
            {
                return _aciklama;
            }
            set
            {
                this._aciklama = value;
                
            }
        }

       
    }

}

