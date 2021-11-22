using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGalery.XamarinForms.Paginas.PaginaDeNavegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void AbrirPage3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }

        private void VoltarPage1(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}