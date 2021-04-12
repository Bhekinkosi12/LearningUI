using OwnAndroid.Layout.Peers;
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
    public partial class Type_Of_Learn : ContentPage
    {
        public Type_Of_Learn()
        {
            InitializeComponent();
        }

        private async void Solo_learining_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Present_page());
            
        }

        private async void Peer_to_Peer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Peer_to_Peer_Present());
        }
    }
}