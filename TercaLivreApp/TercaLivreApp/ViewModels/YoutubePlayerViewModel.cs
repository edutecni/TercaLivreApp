using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using TercaLivreApp.Models;
using TercaLivreApp.Views;
using Xamarin.Forms;

namespace TercaLivreApp.ViewModels
{
    public class YoutubePlayerViewModel : BaseViewModel
    {
        public YoutubePlayerViewModel()
        {
            Title = "YoutubePlayer";            
        }        
    }
}