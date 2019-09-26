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
    public partial class Soru : ContentPage
    {
        public Soru()
        {
            InitializeComponent();
        }

        void Add_Soru(object sender, EventArgs e)
        {

            Model.Soru soru = new Model.Soru(Entry_Tur.Text,Entry_soru.Text,Entry_Nesne_Kod.Text,Entry_Username.Text,Entry_Aciklama.Text);
            SoruDataAcces VT = new SoruDataAcces();
            VT.AddNewHastahaneYonetimSistemi(soru);
            DisplayAlert("Başarılı", "Yeni Soru kaydı oluşturuldu", "Tamam");
        }
    }
}