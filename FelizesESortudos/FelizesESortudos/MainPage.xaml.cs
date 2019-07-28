using FelizesESortudos.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FelizesESortudos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnCalcular.Clicked += Calcular;
        }

        private void Calcular(object sender, EventArgs args)
        {
            lblResultado.Text = TestaNumero.ValidarEntrada(txtNumero.Text);
        }

    }
}
