using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Collections.ObjectModel;
using OwnAndroid.Layout.Subjects.Physics;
using SQLite;

namespace OwnAndroid.Layout.Subjects.Physics
{
  public  class Physics_Data
    {
       

        void Push_Data()
        {
            var PhysicsdataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Physics_data.db");
            var dataB = new SQLiteConnection(PhysicsdataPath);
            dataB.CreateTable<Table_Binding>();
        

            var TopicsOne = new Collection<Table_Binding>
            {

             new Table_Binding   ()
            {

                Sub_subject = "Physics and Chemistry",
                Subject_First = "Physical ",
                Subject_Second = "Sciences",
                Topic = "Mechanics",
                Color = "Red",
                Sub_topic = "Motion , Work, Energy and Power",
                Topic_Description = "Be concerned with motion of Physical objects relative to the environment",
                Topic_Number = 1


            },





         new Table_Binding()
            {
                Sub_subject = "Physics and Chemistry",
                Subject_First = "Physical ",
                Subject_Second = "Sciences",

                Topic = "Waves, sound and light",
                Color = "Blue",
                Sub_topic = "Color, Doppler Effect and more",
                Topic_Description = "Learn the funduments of the nature of matter",
                Topic_Number = 2


            },
            new Table_Binding()
            {
                Sub_subject = "Physics and Chemistry",
                Subject_First = "Physical ",
                Subject_Second = "Sciences",

                Topic = "Electricity and Magnetism",
                Color = "Brown",
                Sub_topic = "Electrodynamics and Electrons",
                Topic_Description = "Be on a learning curve with electricity",
                Topic_Number = 3

            },
             new Table_Binding()
            {
                Sub_subject = "Physics and Chemistry",
                Subject_First = "Physical ",
                Subject_Second = "Sciences",

                Topic = "Matter and Matrial",
                Color = "Green",
                Sub_topic = "Mechanical Properties of materials",
                Topic_Description = "Be concerned with motion of Physical objects relative to the environment",
                Topic_Number = 4

            }

            };
            dataB.Insert(TopicsOne);



        }


    }
}
