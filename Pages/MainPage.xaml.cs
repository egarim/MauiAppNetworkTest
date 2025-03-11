using MauiAppNetworkTest.Models;
using MauiAppNetworkTest.PageModels;

namespace MauiAppNetworkTest.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}