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
	public partial class User : ContentPage
	{
		public User ()
		{
			InitializeComponent ();
		}
        
       
        void Add_User(object sender, EventArgs e)
        {

            Model.User user = new Model.User(User_Kad.Text, User_Password.Text, User_Unvan.Text, S_kod.Text);
            UserDataAcces VT = new UserDataAcces();
            VT.AddNewHastahaneYonetimSistemi(user);
            DisplayAlert("Başarılı", "Yeni Kullanıcı kaydı oluşturuldu", "Tamam");
        }

    }
}