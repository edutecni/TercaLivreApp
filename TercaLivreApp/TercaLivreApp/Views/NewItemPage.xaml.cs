using System;
using System.Collections.Generic;
using System.ComponentModel;
using TercaLivreApp.Models;
using TercaLivreApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TercaLivreApp.Views
{
    public partial class NewSitePage : ContentPage
    {
        public Item Item { get; set; }

        public NewSitePage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}