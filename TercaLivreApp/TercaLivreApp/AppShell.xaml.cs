using System;
using System.Collections.Generic;
using TercaLivreApp.ViewModels;
using TercaLivreApp.Views;
using Xamarin.Forms;

namespace TercaLivreApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewSitePage), typeof(NewSitePage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
