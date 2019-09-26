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
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}
        private async void SingInAdmin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
        
        private async void SingInUser(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

    }
}