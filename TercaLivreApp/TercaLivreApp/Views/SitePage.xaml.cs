using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercaLivreApp.Models;
using TercaLivreApp.ViewModels;
using TercaLivreApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TercaLivreApp.Views
{
    public partial class SitePage : ContentPage
    {
        SiteViewModel _viewModel;

        public SitePage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new SiteViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}