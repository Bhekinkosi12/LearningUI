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
    public partial class Side_Tyle_of_Learn : ContentPage
    {
        public Side_Tyle_of_Learn()
        {
            InitializeComponent();
        }

        private async void Solo_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Present_page()); 

        }

        private void Shared_Tapped(object sender, EventArgs e)
        {

        }

        private void Peer_Tapped(object sender, EventArgs e)
        {

        }
    }
}