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
    public partial class lamborghini : ContentPage
    {
        public lamborghini()
        {
            InitializeComponent();
        }

        private void lamborginimodel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lamborginimodel.Items[lamborginimodel.SelectedIndex] == "Lamborghini Huracan")
            {
                foto1.Source = "lamba1.jpg";
                txt.Text = "Lamborghini Huracan (Ламборгини Хуракан) — спортивный автомобиль с передним приводом, дебют которого состоялся в 2014 году на женевском автосалоне. Модель отличается нетривиальным дизайном кузова, мощностью и комфортабельностью.";
                txt.BackgroundColor = Color.White;
            }

            else if (lamborginimodel.Items[lamborginimodel.SelectedIndex] == "Lamborghini Aventador I")
            {
                foto1.Source = "lamba2.jpg";
                txt.Text = "Первый Lamborghini Aventador LP 700-4 с приставкой Roadster дебютировал на специальном мероприятии в Майами 12 ноября 2012 года, а его мировая премьера состоялась на подмостках Лос-анджелесского автосалона в том же году.";
                txt.BackgroundColor = Color.White;
            }
            else if (lamborginimodel.Items[lamborginimodel.SelectedIndex] == "Lamborghini Urus I")
            {
                foto1.Source = "lamba3.png";
                txt.Text = "Серийная версия Lamborghini Urus впервые предстала перед широкой аудиторией 4 декабря 2017 года, однако, в старом свете, ее дебют пройдет только в марте 2018 на подмостках международного весеннего женевского автосалона.";
                txt.BackgroundColor = Color.White;
            }
        }
    }
}