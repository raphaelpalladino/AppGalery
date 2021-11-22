using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGalery.XamarinForms.Paginas.MenuLateral
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void AbrirPagina1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new XamarinForms.Paginas.PaginaDeNavegacao.Page1());
            //Informa que não é para ficar presente na execução
            //Esconde o menu
            IsPresented = false;
        }

        private void AbrirPagina2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page2());
            IsPresented = false;
        }

        private void AbrirPagina3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page3());
            IsPresented = false;
        }

    }
}