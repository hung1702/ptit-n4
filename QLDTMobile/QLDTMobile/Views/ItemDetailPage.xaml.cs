using QLDTMobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace QLDTMobile.Views
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