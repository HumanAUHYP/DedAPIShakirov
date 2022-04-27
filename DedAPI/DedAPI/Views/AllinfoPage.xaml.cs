using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DedAPI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllinfoPage : ContentPage
    {
        public AllinfoPage(Model.EntrieModel selectedModel)
        {
            InitializeComponent();
            this.BindingContext = selectedModel;
            if (selectedModel.HTTPS)
                lbHttps.Text = "Поддерживает HTTPS";
            else
                lbHttps.Text = "Не поддерживает HTTPS";

            var temp = selectedModel.Link;
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                Launcher.OpenAsync(temp);
            };
            lbUrl.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}