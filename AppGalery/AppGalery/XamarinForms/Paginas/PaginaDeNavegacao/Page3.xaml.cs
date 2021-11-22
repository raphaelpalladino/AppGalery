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
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void PopAsync(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        //Bloqueia o retorno pelo botão voltar no android
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void PopToRootAsync(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void InsertPage(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(
                new Page4(),
                Navigation.NavigationStack[0]
                );

            //Navigation.InsertPageBefore(
            //    new Page1(),
            //    Navigation.NavigationStack[2]
            //    );
        }

        private void RemovePage(object sender, EventArgs e)
        {
            Navigation.RemovePage(Navigation.NavigationStack[0]);
        }

        private void OpenModal(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Modal.Modal1());
        }

        private void OpenCarrossel(object sender, EventArgs e)
        {
            var carrossel = new CarouselPage();

            carrossel.Children.Add(new Carrossel.Carrossel1());
            carrossel.Children.Add(new Carrossel.Carrossel2());
            carrossel.Children.Add(new Carrossel.Carrossel3());

            carrossel.CurrentPage = carrossel.Children[0]; //Inicia o carrossel no índice 1
            Navigation.PushAsync(carrossel);
        }

        private void OpenCarrosselManual(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.Carrossel.CarrosselManual());
        }

        private void OpenDiaba(object sender, EventArgs e)
        {
            var diaba = new TabbedPage();

            diaba.Children.Add(new PaginaDiaba.Diaba1());
            diaba.Children.Add(new PaginaDiaba.Diaba2());
            diaba.CurrentPage = diaba.Children[0];
            Navigation.PushAsync(diaba);

        }
    }
}