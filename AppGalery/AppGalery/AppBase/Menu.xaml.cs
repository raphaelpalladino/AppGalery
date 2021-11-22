using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGalery.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirContentPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeConteudo.Page1();
            //esconde o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirNavigationPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeNavegacao.Page1();
            //esconde o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirCarouselPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.Carrossel.Carrossel1();
            //esconde o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirTabbedPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDiaba.Diaba1();
            //esconde o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirMasterDetaisPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.MenuLateral.Page1();
            //esconde o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirModal(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.Modal.Modal1();
            //esconde o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirStackLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.Stack.Page1();
            //esconde o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirGridLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.Grid.Grid();
            //esconde o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }
    }
}