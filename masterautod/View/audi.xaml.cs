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
                txt.BackgroundColor = Color.LightYellow;
            }

            else if (audimodeli.Items[audimodeli.SelectedIndex] == "Audi Q2")
            {
                foto1.Source = "audi2.webp";
                txt.Text = "Audi Q2-компактный пятиместный кроссовер премиум класса. Его габаритные размеры составляют: длина 4191 мм, ширина 1794 мм, высота 1508 мм, колесная база 2595 мм, а величина дорожного просвета равняется 200 миллиметрам. Это неплохой клиренс для такого компактного автомобиля.";
                txt.BackgroundColor = Color.LightYellow;
            }
            else if (audimodeli.Items[audimodeli.SelectedIndex] == "Audi A6")
            {
                foto1.Source = "audia6.webp";
                txt.Text = "A6 – модель бизнес – класса с переднемоторной компоновкой и передним или полным приводом. Выпускалась в двух вариантах кузова: четырехдверный седан и пятидверный универсал. Годы производства модификации C6: с 2004 по 2011. Автомобили собирались на заводе компании в Ингольштадте в Германии.";
                txt.BackgroundColor = Color.LightYellow;

            }
            else if (audimodeli.Items[audimodeli.SelectedIndex] == "Audi A8 L")
            {
                foto1.Source = "audi4.webp";
                txt.Text = "Audi A8 L — воплощение безупречного автомобиля представительского класса. Удлинённая на 130 мм колёсная база флагмана марки Audi подарит самой взыскательной персоне удовольствие быть пассажиром. Audi A8 L — безупречный выбор тех, кто ценит технологическое совершенство и элегантный дизайн, изысканность и динамику.";
                txt.BackgroundColor = Color.LightYellow;
            }
        }
    }
}