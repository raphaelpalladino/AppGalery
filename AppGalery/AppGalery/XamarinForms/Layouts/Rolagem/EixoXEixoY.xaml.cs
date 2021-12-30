using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGalery.XamarinForms.Layouts.Rolagem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EixoXEixoY : ContentPage
    {
        public EixoXEixoY()
        {
            InitializeComponent();
        }

        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            posicao.Text = e.ScrollX + " - " + e.ScrollY;
        }
    }
}