using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace masterautod
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            foto.Source = ImageSource.FromFile("foto.jpg");
            informasija.ItemsSource = GetMenuList();
            var homepage = typeof(View.bmw);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homepage));
            IsPresented = false;
        }

        private List<menuitems> GetMenuList()
        {
            var list = new List<menuitems>();

            list.Add(new menuitems()
            {
                Text = "BMW",
                Detail = "Все о BMW",
                ImagePath = "bmw.png",
                TargetPage = typeof(View.bmw)
            });
            list.Add(new menuitems()
            {
                Text = "AUDI",
                Detail = "Все о AUDI",
                ImagePath = "audilogo.png",
                TargetPage = typeof(View.audi)
            });
            list.Add(new menuitems()
            {
                Text = "ALFARAMEO",
                Detail = "Все о ALFARAMEO",
                ImagePath = "alfo.png",
                TargetPage = typeof(View.alfarameo)
            });
            list.Add(new menuitems()
            {
                Text = "Chevrolet",
                Detail = "Все о Chevrolet",
                ImagePath = "chevr.png",
                TargetPage = typeof(View.chevrolet)
            });
            list.Add(new menuitems()
            {
                Text = "Mercedes",
                Detail = "Все о Mercedes",
                ImagePath = "mers.png",
                TargetPage = typeof(View.mercedes)
            });

            return list;
        }

        private void informasija_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selected = (menuitems)e.SelectedItem;
            Type selectedpage = selected.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedpage));
            IsPresented = false;
        }
    }
}
