using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OwnAndroid.Layout.Subjects.Questions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OwnAndroid.Layout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Side_Learn_type_one : ContentPage
    {
        public Side_Learn_type_one()
        {
            InitializeComponent();
        }

        private async void BTN_Solo_learning_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Questions_Select_layout());

        }
    }
}