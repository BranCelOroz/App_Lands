using lands.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lands.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            btnir.Clicked += Btnir_Clicked;
		}

        public void Btnir_Clicked(object sender, EventArgs e)
        {
            MainViewModel.GetInstance().Lands = new LandsViewModel();
            Application.Current.MainPage.Navigation.PushAsync(new LandsPage());
        }
    }
}