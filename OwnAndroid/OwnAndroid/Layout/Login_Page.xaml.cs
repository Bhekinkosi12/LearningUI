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
    public partial class Login_Page : ContentPage
    {
       

        public Login_Page()
        {
            InitializeComponent();
        }

        private async void Sign_In_Clicked(object sender, EventArgs e)
        {

            var dataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var dataB = new SQLiteConnection(dataPath);
            var myQuery = dataB.Table<Data_base_User>().Where(u => u.Email.Equals(Entry_Email.Text) && u.Password.Equals(Entry_Password.Text));


            var open_Email = Entry_Email.Text;
            var open_password = Entry_Password.Text;

            var Get_name = dataB.Table<Data_base_User>();

            
            
            
            
            
            
            foreach (var get in Get_name )
            {
                
                    if (open_Email == get.Email && open_password == get.Password)
                    {
                        await Navigation.PushAsync(new TabbedPage1()); 


                        Device.BeginInvokeOnMainThread(async () =>
                        {
                            var result = await this.DisplayAlert("Login", "Login Successed", "OK", "Cancel");


                        });


                    }
                    else
                    {

                        Device.BeginInvokeOnMainThread(async () =>
                        {
                            var result = await this.DisplayAlert("Error", "Email or Password incorrect", "OK", "Cancel");
                            if (result)
                            {
                                await Navigation.PushAsync(new Login_Page());
                            }

                        });
                    }

                    break;
                }

              
              

               

            
           


            
                

        }

        private void Forgot_passwprd_Tapped(object sender, EventArgs e)
        {

        }

        private async void Sign_up_Tapped(object sender, EventArgs e)
        {



            await Navigation.PushAsync(new Sign_Up());




        }
    }
}