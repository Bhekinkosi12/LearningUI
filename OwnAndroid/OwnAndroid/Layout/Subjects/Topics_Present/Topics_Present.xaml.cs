using OwnAndroid.Layout.Subjects.Physics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OwnAndroid.Layout.Subjects.Topics_Present
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Topics_Present : ContentPage
    {
        public Topics_Present()
        {
            InitializeComponent();

            this.BindingContext = this;
        }
       
        public ObservableCollection<Topics> Physics_topics { get => GetTopics(); }

        private ObservableCollection<Topics> GetTopics()
        {
            return new ObservableCollection<Topics>
            {
                new Topics
                {
                     Sub_subject = "Physics and Chemistry",
                     Subject_First = "Physical ",
                      Subject_Second = "Sciences",
                    Topic = "Mechanics" ,
                    Color = "Red" ,
                    Sub_topic = "Motion , Work, Energy and Power" ,
                     Topic_Description = "Be concerned with motion of Physical objects relative to the environment",
                      Topic_Number = 1 ,
                },
                    new Topics
                {
                         Sub_subject = "Physics and Chemistry",
                           Subject_First = "Physical ",
                      Subject_Second = "Sciences",

                    Topic = "Waves, sound and light" ,
                    Color = "Blue" ,
                    Sub_topic = "Color, Doppler Effect and more" ,
                     Topic_Description = "Learn the funduments of the nature of matter",
                     Topic_Number = 2
                },

                        new Topics
                {
                             Sub_subject = "Physics and Chemistry",
                               Subject_First = "Physical ",
                      Subject_Second = "Sciences",

                    Topic = "Electricity and Magnetism" ,
                    Color = "Brown" ,
                    Sub_topic = "Electrodynamics and Electrons" ,
                     Topic_Description = "Be on a learning curve with electricity",
                     Topic_Number = 3
                },

                            new Topics
                {
                                 Sub_subject = "Physics and Chemistry",
                                   Subject_First = "Physical ",
                      Subject_Second = "Sciences",

                    Topic = "Matter and Matrial" ,
                    Color = "Green" ,
                    Sub_topic = "Mechanical Properties of materials" ,
                     Topic_Description = "Be concerned with motion of Physical objects relative to the environment",
                     Topic_Number = 4

                }

              


            };


        }

        //second collection view

        public ObservableCollection<Sub_Base_topic> sub_Machanics_Topics { get => GetBase(); }

        private ObservableCollection<Sub_Base_topic> GetBase()
        {
            return new ObservableCollection<Sub_Base_topic>
            {
                new Sub_Base_topic
                {
                     sub_base1 = "Vertical Projectile Motion",
                      sub_base2 = "Projectile motion in two dimensions",
                       sub_base3 = "Conversations of momentum"


                },
                new Sub_Base_topic
                {
                     sub_base1 = "Work, Energy and Power",
                      sub_base2 = "Work and Energy",
                       sub_base3 = "Power"


                }

            };


        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
          



        }
    }

    public class Topics
        {
            public string Topic { get; set; }
            public string Sub_topic { get; set; }
            public string Topic_Description { get; set; }

            public int Topic_Number { get; set; }

        public string Color { get; set; }

        public string Subject_First { get; set; }
        public string Subject_Second { get; set; }

        public string Sub_subject { get; set; }
      


    }

    public class Sub_Base_topic
    {
        public string sub_base1 { get; set; }

        public string sub_base2 { get; set; }
        public string sub_base3 { get; set; }

        public string sub_base4 { get; set; }




    }
}