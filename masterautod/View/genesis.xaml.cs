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
    public partial class genesis : ContentPage
    {
        public genesis()
        {
            InitializeComponent();
        }

        private void genesis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genesismodel.Items[genesismodel.SelectedIndex] == "Genesis G70 I")
            {
                foto1.Source = "genesis1.jpg";
            }

            else if (genesismodel.Items[genesismodel.SelectedIndex] == "Genesis G80 I")
            {
                foto1.Source = "genesis2.jpg";
            }
            else if (genesismodel.Items[genesismodel.SelectedIndex] == "Genesis G80 II")
            {
                foto1.Source = "genesis3.jpg";
            }
        }
    }
}