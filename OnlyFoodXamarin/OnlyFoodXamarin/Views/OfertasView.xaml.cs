using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnlyFoodXamarin
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OfertasView : ContentPage
    {
        public OfertasView()
        {
            InitializeComponent();
            //BindingContext = App.ServiceLocator.OfertasViewModel;
        }
    }
}