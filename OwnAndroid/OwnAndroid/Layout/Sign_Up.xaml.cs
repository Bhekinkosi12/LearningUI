using OwnAndroid.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OwnAndroid.Layout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sign_Up : ContentPage
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private async void Sign_Up_Clicked(object sender, EventArgs e)
        {
            var dataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var dataB = new SQLiteConnection(dataPath);
            dataB.CreateTable<Data_base_User>();
            try { 

            var item = new Data_base_User()
            {
                Name = Entry_Name.Text,
                Surname = Entry_Surname.Text,
                Email = Entry_Email.Text,
                ID = Entry_ID.Text,
                Password = Entry_password.Text
                

            };
            dataB.Insert(item);
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Connected", $"Registraion Email:{Entry_Email.Text} Password:{Entry_password.Text}", "OK", "Cancel");
                });

                await Navigation.PushAsync(new BT_Tabbed());
            }
            catch
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Failed", "Failed to connect to DataBase", "OK", "Cancel");
                });

                await Navigation.PushAsync(new Sign_Up());

            }

        }
    }
}