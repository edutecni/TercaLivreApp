using System.ComponentModel;
using TercaLivreApp.ViewModels;
using Xamarin.Forms;

namespace TercaLivreApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}