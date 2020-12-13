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
                txt.Text = "Производитель: ALFA ROMEO";
                txt1.Text = "Годы производства: 2010 — настоящее время";
                txt2.Text = "Сборка: Кассино - Piedimonte S. Germano";
                txt3.Text = "Класс: Компактный";
                txt4.Text = "Дизайнер: Centro Stile Alfa Romeo";

            }
           
            else if (alfaromeomodeli.Items[alfaromeomodeli.SelectedIndex] == "ALFA ROMEO 4C")
            {
                foto1.Source = "al2.jpg";
                txt.Text = "Производитель: Alfa Romeo Automobiles S.p.A.";
                txt1.Text = "Годы производства: 2013 — настоящее время";
                txt2.Text = "Сборка: Модена, Эмилия-Романья, Италия";
                txt3.Text = "Класс: Спорткар";
                txt4.Text = "Дизайнер: Лоренцо Рамачоти";
            }
            else if (alfaromeomodeli.Items[alfaromeomodeli  .SelectedIndex] == "ALFA ROMEO Giulia")
            {
                foto1.Source = "alfaremeo4.webp";
                txt.Text = "Производитель: ALFA ROMEO";
                txt1.Text = "Годы производства: 2016 — настоящее время";
                txt3.Text = "Класс: Компактный автомобиль";
                
            }
        }
    }
}