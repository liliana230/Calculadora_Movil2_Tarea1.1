using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        Calculo.Operaciones cal = new Calculo.Operaciones();
        public Decimal n1;
        public Decimal n2;
        public Decimal result;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnsuma_Clicked(object sender, EventArgs e)
        {
             n1 = Convert.ToDecimal(num1.Text);
             n2 = Convert.ToDecimal(num2.Text);

            result = cal.suma (n1, n2);

            await Navigation.PushAsync(new Resultado(result));
        }

        private async void btnresta_Clicked(object sender, EventArgs e)
        {
            n1 = Convert.ToDecimal(num1.Text);
            n2 = Convert.ToDecimal(num2.Text);

            result = cal.resta(n1, n2);

            await Navigation.PushAsync(new Resultado(result));
        }

        private async void btnmultiplicacion_Clicked(object sender, EventArgs e)
        {
            n1 = Convert.ToDecimal(num1.Text);
            n2 = Convert.ToDecimal(num2.Text);

            result = cal.multiplicacion(n1, n2);

            await Navigation.PushAsync(new Resultado(result));
        }

        private async void btndivision_Clicked(object sender, EventArgs e)
        {
            n1 = Convert.ToDecimal(num1.Text);
            n2 = Convert.ToDecimal(num2.Text);

            result = cal.division(n1, n2);

            await Navigation.PushAsync(new Resultado(result));
        }
    }
}
