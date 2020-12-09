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
    public partial class mercedes : ContentPage
    {
        public mercedes()
        {
            InitializeComponent();
        }

        private void merced_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (merced.Items[merced.SelectedIndex] == "Mercedes-Benz X-Class")
            {
                foto1.Source = "merr.jpg";
            }

            else if (merced.Items[merced.SelectedIndex] == "Mercedes-Benz SLC-Class")
            {
                foto1.Source = "merc2.jpg";
            }
            else if (merced.Items[merced.SelectedIndex] == "Mercedes-Benz A-Class")
            {
                foto1.Source = "merc3.jpg";
            }
        }
    }
}