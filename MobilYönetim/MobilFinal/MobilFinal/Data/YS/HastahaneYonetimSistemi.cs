using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MobilFinal
{
    [Table("HastahaneYonetimSistemi")]

    public  class HastahaneYonetimSistemi 
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
        private string _hastaneAdi;

        public string HastaneAdi
        {
            get
            {
                return _hastaneAdi;
            }
            set
            {
                this._hastaneAdi = value;
                
            }

        }
        private string _hastaneKodu;
        public string HastaneKodu
        {
            get
            {
                return _hastaneKodu;
            }
            set
            {
                this._hastaneKodu = value;
               
            }

        }
       

        
    }



}
