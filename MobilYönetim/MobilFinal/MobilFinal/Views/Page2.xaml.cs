using MobilFinal.Model;
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
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
		}
        private async void Soru_ekrani(object sender, EventArgs e)
        {
            
            UserDataAcces VT = new UserDataAcces();           
            List<UserYonetimSistemi> a = VT.GetFilteredHastahaneYonetimSistemi();

            foreach (UserYonetimSistemi item in a)
            {
                if (item.Username == Entry_Username.Text && item.Password == Entry_Password.Text)
                {
                    CevapPage.Username = item.Username;
                    await Navigation.PushAsync(new CevapPage());

                    break;
                }
            }

        }
    }
}