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
    public partial class alfarameo : ContentPage
    {
        public alfarameo()
        {
            InitializeComponent();
        }

        private void alfaromeomodeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (alfaromeomodeli.Items[alfaromeomodeli.SelectedIndex] == "ALFA ROMEO Giulietta")
            {
                foto1.Source = "alfaremeo1.jpg";
            }
           
            else if (alfaromeomodeli.Items[alfaromeomodeli.SelectedIndex] == "ALFA ROMEO 4C Spider")
            {
                foto1.Source = "alfaremeo3.jpg";
            }
            else if (alfaromeomodeli.Items[alfaromeomodeli  .SelectedIndex] == "ALFA ROMEO Giulia Veloce")
            {
                foto1.Source = "alfaremeo4.webp";
            }
        }
    }
}