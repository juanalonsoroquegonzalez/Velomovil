using System;
using System.Collections.Generic;
using Velomovil.ViewModels;
using Velomovil.Views;
using Xamarin.Forms;

namespace Velomovil
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
