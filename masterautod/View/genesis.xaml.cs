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
                txt.Text = "Genesis G70 – премиальный седан дочерней компании бренда Hyundai из Южной Кореи, специализирующейся на выпуске автомобилей люксового сегмента. Модель появилась в 2017 году и смогла покорить автолюбителей из множества стран мира. Она отличается мощными двигателями, прекрасными ходовыми качествами и инновационным оснащением.";
                txt.BackgroundColor = Color.White;
            }

            else if (genesismodel.Items[genesismodel.SelectedIndex] == "Genesis G80 I")
            {
                foto1.Source = "genesis2.jpg";
                txt.Text = "седан бизнес-класса от всемирно известного южнокорейского бренда Hyundai. Его история началась в 2016 году. Именно тогда вышло первое поколение авто с таким названием. Но сам премиальный и роскошный седан этой марки появился в 2013 году. Правда, тогда он назывался Hyundai Genesis. А в 2020 году автомобиль пережил рестайлинг.";
                txt.BackgroundColor = Color.White;
            }
            else if (genesismodel.Items[genesismodel.SelectedIndex] == "Genesis G80 II")
            {
                foto1.Source = "genesis3.jpg";
                txt.Text = "На южнокорейских смотринах автомобильной индустрии в Пусане, распахнувших свои двери для посетителей в начале июня 2016 года, премиальное подразделение компании «Hyundai» – марка «Genesis» – провело мировую презентацию седана E-класса под названием «G80» – перелицованной версии Hyundai Genesis.";
                txt.BackgroundColor = Color.White;
            }
        }
    }
}