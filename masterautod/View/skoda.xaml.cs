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
    public partial class skoda : ContentPage
    {
        public skoda()
        {
            InitializeComponent();
        }

        private void skodamodel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skodamodel.Items[skodamodel.SelectedIndex] == "Skoda Octavia IV")
            {
                foto1.Source = "skoda1.jpg";
                txt.Text = "автомобиль размерного класса C, производимый чешской компанией Škoda Auto a.s. Название современной модели (четыре поколения, начиная с 1996 года) было позаимствовано у предшественника, производимого в 1959—1971 годах.";
            }

            else if (skodamodel.Items[skodamodel.SelectedIndex] == "Skoda Superb III")
            {
                foto1.Source = "skoda2.jpg";
                txt.Text = "легковой автомобиль класса D, выпускаемый чешским автопроизводителем Škoda Auto с 2001 года. Название современных автомобилей было позаимствовано у линейки машин, производившихся в 1934—1949 годах.";
            }
            else if (skodamodel.Items[skodamodel.SelectedIndex] == "Skoda Kodiaq I")
            {
                foto1.Source = "skoda3.png";
                txt.Text = "Является наиболее крупным кроссовером в модельной гамме Škoda Auto, предлагается как в пяти-, так и в семиместной конфигурации. Серийная версия была представлена 1 сентября 2016 года в Берлине.";
            }
        }
    }
}