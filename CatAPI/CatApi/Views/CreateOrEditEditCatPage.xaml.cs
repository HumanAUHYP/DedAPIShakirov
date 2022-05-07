using DedApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DedApi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateOrEditEditCatPage : ContentPage
    {
        bool IsNewCat;

        public CreateOrEditEditCatPage(bool isNewCat = false)
        {
            InitializeComponent();
            IsNewCat = isNewCat;
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var cat = (Cat)BindingContext;
            await App.RequestManager.SaveCatAsync(cat, IsNewCat);
            await Navigation.PopAsync();
        }

        private async void DeleteButton_Clicked(object sender, EventArgs e)
        {
            var cat = (Cat)BindingContext;
            await App.RequestManager.DeleteCatAsync(cat);
            await Navigation.PopAsync();
        }
    }
}