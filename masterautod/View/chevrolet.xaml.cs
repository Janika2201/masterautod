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
    public partial class chevrolet : ContentPage
    {
        public chevrolet()
        {
            InitializeComponent();
        }

        private void sevrolemodel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sevrolemodel.Items[sevrolemodel.SelectedIndex] == "Corvette")
            {
                foto1.Source = "sevrole1.jpg";
                
            }

            else if (sevrolemodel.Items[sevrolemodel.SelectedIndex] == "Camaro")
            {
                foto1.Source = "Camaro.jpg";
            }
            else if (sevrolemodel.Items[sevrolemodel.SelectedIndex] == "Silverado")
            {
                foto1.Source = "Silverado.jpg";
            }
            else if (sevrolemodel.Items[sevrolemodel.SelectedIndex] == "Onix")
            {
                foto1.Source = "Onix.jpg";
            }
        }
    }
}