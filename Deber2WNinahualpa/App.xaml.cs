using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Deber2WNinahualpa
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // habilitar la navegaciòn
            //MainPage = new NavigationPage(new MainPage());
            MainPage = new NavigationPage(new Ventana());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
