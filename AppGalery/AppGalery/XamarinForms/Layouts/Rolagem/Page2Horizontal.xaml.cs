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
    public partial class Page2Horizontal : ContentPage
    {
        public Page2Horizontal()
        {
            InitializeComponent();
        }

        private void irFinal(object sender, EventArgs e)
        {
            BarraRolagem.ScrollToAsync(final, ScrollToPosition.Start, true);
        }

        private void irComeco(object sender, EventArgs e)
        {
            BarraRolagem.ScrollToAsync(inicio, ScrollToPosition.Start, true);
        }
    }
}