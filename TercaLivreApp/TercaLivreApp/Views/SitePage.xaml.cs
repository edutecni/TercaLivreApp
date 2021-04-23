using TercaLivreApp.ViewModels;
using Xamarin.Forms;

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