using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OwnAndroid.Data;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OwnAndroid.Layout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile_page : ContentPage
    {
        public Profile_page()
        {
            InitializeComponent();
            Binding_Name();
        }

       
        public void Binding_Name()
        {
            var dataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var dataB = new SQLiteConnection(dataPath);

            try
            {
                var Get_name = dataB.Table<Data_base_User>();  
                
                foreach(var s in Get_name)
                {
                    LB_profile_Name.Text = s.Name;
                    break;

                }
            
            }
            catch
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Cant access dataBase", "OK", "Cancel");
                    if (result)
                    {
                        await Navigation.PushAsync(new Login_Page());
                    }
                    else
                    {
                        await Navigation.PushAsync(new Login_Page());
                    }

                });

            }


        }

        private  void Edit_bio_Tapped(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayPromptAsync("Edit Bio", "Tell us about yourself");
                SPAN_bio.Text = result;

            });

        }
    }
}