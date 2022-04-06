using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrimeiraAtividade
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;

        private void btnContagem_Clicked(object sender, EventArgs e)
        {
            count++;
            ((Button)sender).Text = "Você clicou " + count.ToString() + "Vezes";
        }

        private async Task btnLimpar_ClickedAsync(object sender, EventArgs e)
        {
            if(await DisplayAlert("Pergunta", "Deseja realmente Limpar?", "Yes", "No"))
            {
                btnContagem.Text = "Clique Aqui";
                count = 0;
            }
        }
    }
}
