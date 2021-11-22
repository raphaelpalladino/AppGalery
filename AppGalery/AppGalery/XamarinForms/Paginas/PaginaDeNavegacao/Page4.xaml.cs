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
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void VoltarParaHome(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(
                new Paginas.PaginaDeConteudo.Page1() 
                );

        }
    }
}