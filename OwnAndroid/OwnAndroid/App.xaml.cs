using OwnAndroid.Layout;

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("Montserrat-Bold.ttf", Alias ="ThemeFontBold")]
[assembly: ExportFont("Montserrat-Medium.ttf", Alias = "ThemeFontMedium")]
[assembly: ExportFont("Montserrat-Regular.ttf", Alias = "ThemeFontRegular")]
[assembly: ExportFont("Montserrat-SemiBold.ttf", Alias = "ThemeFontSemiBold")]
[assembly: ExportFont("UIFontIcons.ttf", Alias = "ThemeFontUI")]
namespace OwnAndroid
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            

            MainPage = new NavigationPage(new Login_Page());

            
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
