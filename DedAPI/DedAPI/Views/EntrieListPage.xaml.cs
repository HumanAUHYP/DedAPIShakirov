using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DedAPI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntrieListPage : ContentPage
    {
        List<Model.EntrieModel> Source;
        public EntrieListPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            LVDeds.ItemsSource = await App.RequestManager.GetEntrieModels();
            Source = (List<Model.EntrieModel>)LVDeds.ItemsSource;
        }

        private void btnSortAZ_Clicked(object sender, EventArgs e)
        {
            Source = Source.OrderBy(a => a.API).ToList();
            LVDeds.ItemsSource = Source;
        }

        private void btnSortZA_Clicked(object sender, EventArgs e)
        {
            Source = Source.OrderByDescending(a => a.API).ToList();
            LVDeds.ItemsSource = Source;
        }

        private async void LVDeds_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedModel = LVDeds.SelectedItem as Model.EntrieModel;
            await Navigation.PushAsync(new AllinfoPage(selectedModel));
        }

        private void btnSupportNot_Clicked(object sender, EventArgs e)
        {
            Source = Source.FindAll(a => a.HTTPS == false);
            LVDeds.ItemsSource = Source;
        }
    }
}