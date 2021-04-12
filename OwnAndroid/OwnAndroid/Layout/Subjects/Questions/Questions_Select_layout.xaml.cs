using OwnAndroid.Layout.Subjects.Maths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OwnAndroid.Layout.Subjects.Questions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Questions_Select_layout : ContentPage
    {
        public Questions_Select_layout()
        {
            InitializeComponent();
        }

        private void BTN_first_Ans_Clicked(object sender, EventArgs e)
        {
            Check_First.IsChecked = true;

        }

        private void BTN_Second_ANS_Clicked(object sender, EventArgs e)
        {
            Check_Second.IsChecked = true;

        }

        private void BTN_Third_ANS_Clicked(object sender, EventArgs e)
        {
            Check_Third.IsChecked = true;

        }

        private void BTN_Fouth_ANS_Clicked(object sender, EventArgs e)
        {
            Check_Fourth.IsChecked = true;

        }

        private async void BTN_submit_Clicked(object sender, EventArgs e)
        {

            if(Check_Fourth.IsChecked == true && Check_Second.IsChecked == true)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Correct", "This increases your experience level", "Next", "Try Again");
                });

                await Navigation.PushAsync(new Learning_Demo());

            }
          

        }
    }
}