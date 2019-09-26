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
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
		}
        private async void add_h(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Hastahane());
        }
        private async void add_s(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sube());
        }
        private async void add_u(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new User());
        }
        private async void add_So(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Soru());
        }
        
        private async void btn_cevap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Soru());
        }
    }
}