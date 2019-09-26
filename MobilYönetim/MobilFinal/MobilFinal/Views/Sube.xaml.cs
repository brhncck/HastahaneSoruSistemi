using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilFinal.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Sube : ContentPage
	{
		public Sube ()
		{
			InitializeComponent ();
		}
        void Add_sube(object sender, EventArgs e)
        {
          
            Model.Sube sube = new Model.Sube(Entry_Sube_adi.Text, Entry_Sube_Kodu.Text, Entry_H_Kodu.Text);            
            SubeDataAcces VT = new SubeDataAcces();
            VT.AddNewHastahaneYonetimSistemi(sube);
            DisplayAlert("Başarılı", "Yeni Sube kaydı oluşturuldu", "Tamam");
        }
    }
}