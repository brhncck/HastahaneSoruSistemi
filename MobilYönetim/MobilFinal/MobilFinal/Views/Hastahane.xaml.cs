using System;

using MobilFinal.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilFinal.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Hastahane : ContentPage
	{
		public Hastahane ()
		{
			InitializeComponent ();
		}
        HastaneDataAcces VT = new HastaneDataAcces();
        void Add_hastane(object sender, EventArgs e)
        {

            Model.Hastane hastane = new Model.Hastane(Entry_H_ad.Text, Entry_H_kod.Text);
            VT.AddNewHastahaneYonetimSistemi(hastane);
                        
            DisplayAlert("Başarılı", "Yeni hastahane kaydı oluşturuldu", "Tamam");
        }
        
    }
}