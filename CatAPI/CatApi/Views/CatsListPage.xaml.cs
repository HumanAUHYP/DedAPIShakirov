using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DedApi.Model;

namespace DedApi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CatsListPage : ContentPage
    {
        public List<Cat> Cats { get; set; }

        public CatsListPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            lvCats.ItemsSource = await App.RequestManager.GetCats();
        }

        private void lvCats_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new CreateOrEditEditCatPage()
            {
                BindingContext = e.SelectedItem as Cat
            });
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateOrEditEditCatPage(true)
            {
                BindingContext = new Cat()
                {
                    Id = Guid.NewGuid().ToString(),
                }
            });
        }
    }
}