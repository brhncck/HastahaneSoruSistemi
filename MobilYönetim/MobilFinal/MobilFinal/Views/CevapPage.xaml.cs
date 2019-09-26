using Android.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace MobilFinal.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CevapPage : ContentPage
	{

        public static string Username { get; set; }
		public CevapPage ()
		{
			InitializeComponent ();
           
            

            SoruDataAcces soru = new SoruDataAcces();
            soru.GetFilteredHastahaneYonetimSistemi(Username);
            List<SoruYonetimSistemi> a = soru.GetFilteredHastahaneYonetimSistemi(Username);

            foreach (SoruYonetimSistemi item in a)
            {
                if (item.Tur=="1")
                {
                    Xamarin.Forms.Label label = new Xamarin.Forms.Label
                    {
                        Text = item.Soru_ekle
                    };

                    Stack.Children.Add(label);

                    Xamarin.Forms.Label label1 = new Xamarin.Forms.Label
                    {
                        Text = item.Nesne_kod
                    };

                    Stack.Children.Add(label1);

                    Xamarin.Forms.Label label2 = new Xamarin.Forms.Label
                    {
                        Text = item.Aciklama
                    };

                    Stack.Children.Add(label2);

                    Xamarin.Forms.Entry entry = new Xamarin.Forms.Entry
                    {
                       
                    };

                    Stack.Children.Add(entry);

                    Xamarin.Forms.Button button = new Xamarin.Forms.Button
                    {
                        Text = "Cevapla"                        
                    };

                    Stack.Children.Add(button);

                    button.Clicked += Button_Clicked;

                }
                else
                {
                    Xamarin.Forms.Label label = new Xamarin.Forms.Label
                    {
                        Text = item.Soru_ekle
                    };

                    Stack.Children.Add(label);

                    Xamarin.Forms.Label label1 = new Xamarin.Forms.Label
                    {
                        Text = item.Nesne_kod
                    };

                    Stack.Children.Add(label1);

                    Xamarin.Forms.Label label2 = new Xamarin.Forms.Label
                    {
                        Text = item.Aciklama
                    };

                    Stack.Children.Add(label2);

                    Xamarin.Forms.Button button = new Xamarin.Forms.Button
                    {
                        Text = "Evet"
                    };

                    Stack.Children.Add(button);

                    button.Clicked += Button_ClickedEvt;

                    Xamarin.Forms.Button button1 = new Xamarin.Forms.Button
                    {
                        Text = "Hayır"
                    };

                    Stack.Children.Add(button1);

                    button1.Clicked += Button_ClickedHyr;
                }


                /*
                Xamarin.Forms.Button button = new Xamarin.Forms.Button
                {
                    Text = "My button"
                };

                Stack.Children.Add(button);
                */
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           
        }
        private void Button_ClickedEvt(object sender, EventArgs e)
        {

        }
        private void Button_ClickedHyr(object sender, EventArgs e)
        {

        }

    }
}