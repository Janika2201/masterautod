using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace masterautod.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class bmw : ContentPage
    {
        public bmw()
        {
            InitializeComponent();
        }

        

        private void modelbmw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelbmw.Items[modelbmw.SelectedIndex] == "Salong-Салон")
            {
                foto1.Source = "salonbmw.jpg";
            }

            else if (modelbmw.Items[modelbmw.SelectedIndex] == "Rool-Руль")
            {
                foto1.Source = "rul.jpg";
            }
            else if (modelbmw.Items[modelbmw.SelectedIndex] == "Tagavaade-Задний вид")
            {
                foto1.Source = "zadbmw.jpg";
            }
            else if (modelbmw.Items[modelbmw.SelectedIndex] == "Kohad-Сиденья")
            {
                foto1.Source = "seden.jpg";
            }
            else if (modelbmw.Items[modelbmw.SelectedIndex] == "Külgvaade-Боковой вид")
            {
                foto1.Source = "vidzob.jpg";
            }
            
        }
    }
}