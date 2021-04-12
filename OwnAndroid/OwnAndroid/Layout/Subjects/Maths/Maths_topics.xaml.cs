using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OwnAndroid.Layout.Subjects.Maths
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Maths_topics : ContentPage
    {
        public Maths_topics()
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
                     Sub_subject = "Maths and Maths lite",
                     Subject_First = "Mathematics ",
                      Subject_Second = "Star",
                    Topic = "Sequences and series" ,
                    Color = "Red" ,
                    Sub_topic = "Motion , Work, Energy and Power" ,
                     Topic_Description = "Be concerned with motion of Physical objects relative to the environment",
                      Topic_Number = 1,
                       sub_base1 = "Start"
                },
                    new Topics
                {
                         Sub_subject = "Maths and Maths lite",
                     Subject_First = "Mathematics ",
                      Subject_Second = "Star",
                 Topic = "Functions" ,
                    Color = "Blue" ,
                    Sub_topic = "Color, Doppler Effect and more" ,
                     Topic_Description = "Learn the funduments of the nature of matter",
                     Topic_Number = 2,
                       sub_base1 = "Start"
                },

                        new Topics
                {
                      Sub_subject = "Maths and Maths lite",
                     Subject_First = "Mathematics ",
                      Subject_Second = "Star",
                  Topic = "Financial Math" ,
                    Color = "Brown" ,
                    Sub_topic = "Electrodynamics and Electrons" ,
                     Topic_Description = "Be on a learning curve with electricity",
                     Topic_Number = 3,
                       sub_base1 = "Start"
                },

                            new Topics
                {   Sub_subject = "Maths and Maths lite",
                     Subject_First = "Mathematics ",
                      Subject_Second = "Star",
                   Topic = "Trigonometry" ,
                    Color = "Green" ,
                    Sub_topic = "Mechanical Properties of materials" ,
                     Topic_Description = "Be concerned with motion of Physical objects relative to the environment",
                     Topic_Number = 4,
                       sub_base1 = "Start"

                },

                            new Topics
                {   Sub_subject = "Maths and Maths lite",
                     Subject_First = "Mathematics ",
                      Subject_Second = "Star",
                Topic = "Polunomials" ,
                    Color = "Blue" ,
                    Sub_topic = "Mechanical Properties of materials" ,
                     Topic_Description = "Be concerned with motion of Physical objects relative to the environment",
                     Topic_Number = 5,
                       sub_base1 = "Start"

                },

                            new Topics
                {   Sub_subject = "Maths and Maths lite",
                     Subject_First = "Mathematics ",
                      Subject_Second = "Star",
                Topic = "Differential calculus" ,
                    Color = "Green" ,
                    Sub_topic = "Mechanical Properties of materials" ,
                     Topic_Description = "Be concerned with motion of Physical objects relative to the environment",
                     Topic_Number = 6,
                       sub_base1 = "Start"

                },

                            new Topics
                {    Sub_subject = "Maths and Maths lite",
                     Subject_First = "Mathematics ",
                      Subject_Second = "Star",
                Topic = "Analytical geometry" ,
                    Color = "Yellow" ,
                    Sub_topic = "Mechanical Properties of materials" ,
                     Topic_Description = "Be concerned with motion of Physical objects relative to the environment",
                     Topic_Number = 7,
                       sub_base1 = "Start"

                },

                            new Topics
                {   Sub_subject = "Maths and Maths lite",
                     Subject_First = "Mathematics ",
                      Subject_Second = "Star",
                 Topic = "Euclidean Geometry" ,
                    Color = "Pink" ,
                    Sub_topic = "Mechanical Properties of materials" ,
                     Topic_Description = "Be concerned with motion of Physical objects relative to the environment",
                     Topic_Number = 8,
                       sub_base1 = "Start"

                },

                            new Topics
                {   Sub_subject = "Maths and Maths lite",
                     Subject_First = "Mathematics ",
                      Subject_Second = "Star",
                  Topic = "Statistics" ,
                    Color = "Black" ,
                    Sub_topic = "Mechanical Properties of materials" ,
                     Topic_Description = "Be concerned with motion of Physical objects relative to the environment",
                     Topic_Number = 9,
                       sub_base1 = "Start"

                },

                            new Topics
                {   Sub_subject = "Maths and Maths lite",
                     Subject_First = "Mathematics ",
                      Subject_Second = "Star",
                    Topic = "Counting Probability" ,
                    Color = "Green" ,
                    Sub_topic = "Mechanical Properties of materials" ,
                     Topic_Description = "Be concerned with motion of Physical objects relative to the environment",
                     Topic_Number = 10,
                       sub_base1 = "Start"

                },

                            new Topics
                {   Sub_subject = "Maths and Maths lite",
                     Subject_First = "Mathematics ",
                      Subject_Second = "Star",
                  Topic = "Data Sheets" ,
                    Color = "Green" ,
                    Sub_topic = "Mechanical Properties of materials" ,
                     Topic_Description = "Be concerned with motion of Physical objects relative to the environment",
                     Topic_Number = 11,
                       sub_base1 = "Start"

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

        public string sub_base1 { get; set; }

        public string sub_base2 { get; set; }
        public string sub_base3 { get; set; }

        public string sub_base4 { get; set; }




    }
}