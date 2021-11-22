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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void AbrirMenu(object sender, EventArgs e)
        {
            //Faz um cast para masterDetaisPage para a página atual
            //Pegando uma pagina global App.Current.MainPage
            ((MasterDetailPage)App.Current.MainPage).IsPresented = true;
        }
    }
}