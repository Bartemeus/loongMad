using System;
using System.Collections.Generic;
using Student.ViewModels;
using Xamarin.Forms;

namespace Student.Views
{
    public partial class SchedulePage : ContentPage
    {
        BaseViewModel viewModel;
        public SchedulePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new BaseViewModel();
            viewModel.DataStore.AddItemAsync(new Models.Item {  Id= Guid.NewGuid().ToString(),
                Text="sad", Description="we"
                    }
                );
        }
    }
}
