using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velomovil1.Models;
using Velomovil1.ViewModels;
using Velomovil1.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Velomovil1.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

    }
}