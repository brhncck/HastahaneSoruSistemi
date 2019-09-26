using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MobilFinal
{
    [Table("SubeYonetimSistemi")]

    public class SubeYonetimSistemi 
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
        private string _SubeAdı;

        public string SubeAdı
        {
            get
            {
                return _SubeAdı;
            }
            set
            {
                this._SubeAdı = value;
                
            }

        }
        private string _subeKodu;
        public string SubeKodu
        {
            get
            {
                return _subeKodu;
            }
            set
            {
                this._subeKodu = value;
                
            }

        }
        private string _hastaneID;
        public string Hastahe
        {
            get
            {
                return _hastaneID;
            }
            set
            {
                this._hastaneID = value;
               
            }

        }
       
    }

}
