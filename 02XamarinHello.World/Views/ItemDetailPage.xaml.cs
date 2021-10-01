using _02XamarinHello.World.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace _02XamarinHello.World.Views
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