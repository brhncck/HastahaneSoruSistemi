using System;
using System.Collections.Generic;
using System.Text;

namespace MobilFinal.Model
{
    public class Sube
    {
        public int Id { get; set; }
        public string S_ad { get; set; }
        public string S_kod { get; set; }
        public String H_kod { get; set; }
        public Sube() { }

        public Sube(string S_ad, string S_kod, string H_kod)
        {
            this.S_ad = S_ad;
            this.S_kod = S_kod;
            this.H_kod = H_kod;
        }
    }
}
