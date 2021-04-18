using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TercaLivreApp.ViewModels
{
    public class SobreViewModel : BaseViewModel
    {
        public SobreViewModel()
        {
            Title = "Sobre";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://tercalivre.com.br"));
        }

        public ICommand OpenWebCommand { get; }
    }
}