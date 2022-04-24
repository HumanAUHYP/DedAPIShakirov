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
        }
    }
}