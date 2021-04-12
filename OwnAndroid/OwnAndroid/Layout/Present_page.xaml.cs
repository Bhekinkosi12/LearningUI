using OwnAndroid.Layout.Subjects.Life_science;
using OwnAndroid.Layout.Subjects.Maths;
using OwnAndroid.Layout.Subjects.Topics_Present;
using OwnAndroid.Layout.Subjects.Accounting;
using OwnAndroid.Layout.Subjects.Computer_application;
using OwnAndroid.Layout.Subjects.Language;
using OwnAndroid.Layout.Subjects.Physics;



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OwnAndroid.Layout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Present_page : ContentPage
    {
        public Present_page()
        {
            InitializeComponent();
        }

       

        private async void LB_Physics_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Topics_Present());
            
        }

        private async void LB_Life_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Life_sciences());
        }

        private async void LB_Accounting_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Accounting_PB());

        }

        private async void LB_Language_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Language_PG());
        }

        private async void LB_CAT_Tapped(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Computer_PG());
        }
        private async void Math_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Maths_topics());
        }

       
    }
}