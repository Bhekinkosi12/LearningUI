using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Shapes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OwnAndroid.Layout.Peers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Peer_to_Peer_Present : ContentPage
    {
        public Peer_to_Peer_Present()
        {
            InitializeComponent();
        }

        private async void Avant_One_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Profile_page());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}