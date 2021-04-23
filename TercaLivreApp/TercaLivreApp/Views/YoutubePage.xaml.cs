using TercaLivreApp.ViewModels;
using Xamarin.Forms;

namespace TercaLivreApp.Views
{
    public partial class YoutubePage : ContentPage
    {
        YoutubeViewModel _viewModel;

        public YoutubePage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new YoutubeViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}