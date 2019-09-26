using System;
using System.Collections.Generic;
using System.Text;

namespace MobilFinal.Model
{
    public class Hastane
    {
        public int Id { get; set; }
        public string H_ad { get; set; }
        public string H_kod { get; set; }
        public Hastane() { }
        public Hastane(string H_ad,string H_kod)
        {
            this.H_ad = H_ad;
            this.H_kod = H_kod;
        }
    }
}
