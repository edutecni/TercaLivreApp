using TercaLivreApp.ViewModels;
using Xamarin.Forms;
using Google.Apis.YouTube.v3;

namespace TercaLivreApp.Views
{
    public partial class YoutubePlayerPage : ContentPage
    {
        YoutubePlayerViewModel _viewModel;

        public YoutubePlayerPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new YoutubePlayerViewModel();

            //YouTubeService youTubeService = new YouTubeService();
            //YoutubePlayerPage youtubePlayerPage = new YoutubePlayerPage();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}