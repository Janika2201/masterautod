using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace masterautod.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class chevrolet : ContentPage
    {
        Uri ur;
        public chevrolet()
        {
            InitializeComponent();
        }

        private void sevrolemodel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sevrolemodel.Items[sevrolemodel.SelectedIndex] == "Corvette")
            {
                foto1.Source = "sevrole1.jpg";
                txt.Text = "Тип: легковой автомобиль";
                txt1.Text = "Тип кузова: купе";
                txt2.Text = "Первичная рег: 09/2006";
                txt3.Text = "Двигатель: 7.0 v8 (377 kW)";
                txt4.Text = "Топливо: бензин";
                txt5.Text = "Коробка передач: механическая КП";
                txt6.Text = "Цена: 38 000 EUR";
                btn.Clicked += Btn_Clicked;


            }

            else if (sevrolemodel.Items[sevrolemodel.SelectedIndex] == "Camaro")
            {
                foto1.Source = "Camaro.jpg";
                txt.Text = "Тип: легковой автомобиль";
                txt1.Text = "Тип кузова: хетчбэк";
                txt2.Text = "Первичная рег: 12/1995";
                txt3.Text = "Двигатель: 5.7 (210 kW)";
                txt4.Text = "Топливо: бензин";
                txt5.Text = "Коробка передач: автомат";
                txt6.Text = "Цена: 14 000 EUR, скидка 12 800 EUR";
            }
            else if (sevrolemodel.Items[sevrolemodel.SelectedIndex] == "Silverado")
            {
                foto1.Source = "Silverado.jpg";
                txt1.Text = "Тип кузова: пикап";
                txt2.Text = "Первичная рег: 09/2012";
                txt3.Text = "Двигатель: 5.7 (210 kW)";
                txt4.Text = "Топливо: бензин А-92(США)";
                txt5.Text = "Коробка передач: автомат 4 ст";
                txt6.Text = "Цена: 13424,47 EUR";
            }
            else if (sevrolemodel.Items[sevrolemodel.SelectedIndex] == "Onix")
            {
                foto1.Source = "Onix.jpg";
                txt1.Text = "Начало выпуска: 2012";
                txt2.Text = "Класс: Класс A";
                txt3.Text = "Модель: Onix";
                txt4.Text = "Топливо: бензин";
                txt5.Text = "Бренд: Chevrolet";
                txt6.Text = "Цена: 1230,58 EUR";
            }
        }

        

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            ur = new Uri("https://avto-russia.ru/autos/chevrolet/");
            await Browser.OpenAsync(ur);
        }
    }
}