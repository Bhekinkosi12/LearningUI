using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OwnAndroid.Layout.Subjects.Accounting
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Accounting_PB : ContentPage
    {
        public Accounting_PB()
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
                      Topic_Number = 1
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

}