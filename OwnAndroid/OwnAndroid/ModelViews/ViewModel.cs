using OwnAndroid.Layout;
using OwnAndroid.Layout.Subjects.Maths;
using OwnAndroid.Layout.Subjects.Questions;
using Syncfusion.XForms.TabView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OwnAndroid.ModelViews
{
   public  class ViewModel : INotifyPropertyChanged
    {
        private TabItemCollection items;
        public event PropertyChangedEventHandler PropertyChanged;

        public TabItemCollection Items
        {
            get { return items; }
            set { items = value;
                OnPropertyChanged("Items");
            }


        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));



        }
        public ViewModel()
        {
            SetItems();


        }
        internal void SetItems()
        {
            Items = new TabItemCollection();

            Profile_page page1 = new Profile_page();
          //  Questions_Select_layout page2 = new Questions_Select_layout();


            Learning_Demo page3 = new Learning_Demo();
            Side_Learn_type_one page4 = new Side_Learn_type_one();

            Present_page page2 = new Present_page(); 
            Items.Add(new SfTabItem { Content = page1.Content, Title = "Profile" });
            Items.Add(new SfTabItem { Content = page2.Content, Title = "Context" });
            Items.Add(new SfTabItem { Content = page3.Content, Title = "Test" });
            Items.Add(new SfTabItem { Content = page4.Content, Title = "Settings"   });

            


        }



    }
}
