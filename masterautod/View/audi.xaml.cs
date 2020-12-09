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
    public partial class audi : ContentPage
    {
        public audi()
        {
            InitializeComponent();
        }

        private void audimodeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (audimodeli.Items[audimodeli.SelectedIndex] == "Audi A4")
            {
                foto1.Source = "audi5.jpg";
                txt.Text = "AUDI A4 — автомобиль среднего класса с двигателем продольного расположения, передним или полным приводом. Является преемником Audi 80, выпускавшейся в 1986-1994 гг.";
            }

            else if (audimodeli.Items[audimodeli.SelectedIndex] == "Audi Q2")
            {
                foto1.Source = "audi2.webp";
            }
            else if (audimodeli.Items[audimodeli.SelectedIndex] == "Audi A6")
            {
                foto1.Source = "audia6.webp";
            }
            else if (audimodeli.Items[audimodeli.SelectedIndex] == "Audi A8 L")
            {
                foto1.Source = "audi4.webp";
            }
        }
    }
}