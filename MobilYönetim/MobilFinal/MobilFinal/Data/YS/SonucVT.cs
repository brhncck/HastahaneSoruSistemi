using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobilFinal.Data.YS
{
    
    [Table("SonucVT")]

    public class SonucVT
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
        private string _cevap;

        public string Cevap
        {
            get
            {
                return _cevap;
            }
            set
            {
                this._cevap = value;

            }

        }
        private string _sorukod;
        public string SoruKod
        {
            get
            {
                return _sorukod;
            }
            set
            {
                this._sorukod = value;

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



    }
}
