using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XLFontAwesome
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new XLFontAwesomeShell();
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
