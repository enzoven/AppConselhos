using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppConselhos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnPrevisao_Clicked(object sender, EventArgs e)
        {
       var result = DisplayAlert("Alerta", "Deseja realmente sair?", "ok");
    } 

    }
}
