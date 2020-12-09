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
    public partial class moskvits : ContentPage
    {
        public moskvits()
        {
            InitializeComponent();
        }

        private void moskvitmodel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (moskvitmodel.Items[moskvitmodel.SelectedIndex] == "Moskvits 403")
            {
                foto1.Source = "mosk1.jpg";
            }

            else if (moskvitmodel.Items[moskvitmodel.SelectedIndex] == "Moskvits 401")
            {
                foto1.Source = "mosk2.jpg";
            }
            else if (moskvitmodel.Items[moskvitmodel.SelectedIndex] == "Moskvits 412")
            {
                foto1.Source = "mosk3.jpg";
            }
        }
    }
}