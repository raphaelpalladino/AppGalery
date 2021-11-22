using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGalery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var pagina = new NavigationPage(new XamarinForms.Paginas.PaginaDeNavegacao.Page1());

            /*
            var menu = new MasterDetailPage();
            //menu
            menu.Master = ;
            //Conteudo
            menu.Detail = ;
            */
            MainPage = new AppBase.Menu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
