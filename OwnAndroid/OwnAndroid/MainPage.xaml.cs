using OwnAndroid.Layout;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OwnAndroid
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;

            welcomeLB();
            loginLB();
            userEntry();
            passwordLB();
            submitBTN();
            


        }



        private async void BTN_submit_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Profile_page());

        }

        public void backgroud_source()
        {
            

        }


        public void welcomeLB()
        {
            
            LB_wecome.Text = "Welcome";
            LB_wecome.TextColor = Color.Black;
            LB_wecome.HeightRequest = 150;
            LB_wecome.FontSize = 40;
            LB_wecome.HorizontalTextAlignment = TextAlignment.Center;
            LB_wecome.VerticalTextAlignment = TextAlignment.Center;


        }
        public void loginLB()
        {
            LB_login.Text = "Login";
            LB_login.TextColor = Color.Black;
            LB_login.VerticalOptions = LayoutOptions.End;
            LB_login.HorizontalOptions = LayoutOptions.Center;
            LB_login.HeightRequest = 40;



        }
        public void userEntry()
        {

            ENTRY_username.Placeholder = "Username/E-mail";
            ENTRY_username.PlaceholderColor = Color.Black;

        }
        public void passwordLB()
        {
            LB_password.Text = "Password";
            LB_password.TextColor = Color.Black;
            LB_password.HorizontalOptions = LayoutOptions.Center;
            LB_password.VerticalOptions = LayoutOptions.End;
            LB_password.HeightRequest = 40;

        }
        public void submitBTN()
        {


            BTN_submit.HeightRequest = 60;
                   BTN_submit.Text = "Submit";
                   BTN_submit.TextColor = Color.Black;
                   BTN_submit.BackgroundColor = Color.Gray;
                   BTN_submit.BorderColor = Color.Red;
                   BTN_submit.FontSize = 20;
                   BTN_submit.CornerRadius = 5;
                     BTN_submit.Opacity = 0.7;
        }

        public void passwordEntry()
        {
            ENTRY_password.Placeholder = "password";
            ENTRY_password.IsPassword = true;
            ENTRY_password.HeightRequest = 40;




        }
        public void signLabel()
        {




           
            LB_signup.Text = "Not registered : SignUp";

            LB_signup.FontSize = 15;
            LB_signup.HorizontalTextAlignment = TextAlignment.Center;


        }







        public ObservableCollection<Album> MyImages { get; set; }
       

        //the end 
    }


    public class Album
    {
        public string Image { get; set; }

        public string Description { get; set; }

    }

        };






        

    
   

