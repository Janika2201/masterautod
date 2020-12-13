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
    public partial class toyota : ContentPage
    {
        public toyota()
        {
            InitializeComponent();
        }

        private void modeltoy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modeltoy.Items[modeltoy.SelectedIndex] == "Salong-Салон")
            {
                foto1.Source = "salonty.jpg";
            }

            else if (modeltoy.Items[modeltoy.SelectedIndex] == "Rool-Руль")
            {
                foto1.Source = "rul1.jpg";
            }
            else if (modeltoy.Items[modeltoy.SelectedIndex] == "Tagavaade-Задний вид")
            {
                foto1.Source = "zadty.jpg";
            }
            else if (modeltoy.Items[modeltoy.SelectedIndex] == "Kohad-Сиденья")
            {
                foto1.Source = "seden1.jpg";
            }
            else if (modeltoy.Items[modeltoy.SelectedIndex] == "Külgvaade-Боковой вид")
            {
                foto1.Source = "bok.jpg";
            }
        }
    }
}