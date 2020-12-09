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
    public partial class skoda : ContentPage
    {
        public skoda()
        {
            InitializeComponent();
        }

        private void skodamodel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skodamodel.Items[skodamodel.SelectedIndex] == "Skoda Octavia IV")
            {
                foto1.Source = "skoda1.jpg";
            }

            else if (skodamodel.Items[skodamodel.SelectedIndex] == "Skoda Superb III")
            {
                foto1.Source = "skoda2.jpg";
            }
            else if (skodamodel.Items[skodamodel.SelectedIndex] == "Skoda Kodiaq I")
            {
                foto1.Source = "skoda3.png";
            }
        }
    }
}