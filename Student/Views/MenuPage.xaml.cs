using Student.Models;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace Student.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Новости" },
                new HomeMenuItem { Id = MenuItemType.Schedule, Title = "Расписание" },
                new HomeMenuItem { Id = MenuItemType.Group, Title = "Группы" },
            };
            if (menuItems.Count == 2)
            {
                menuItems.Add(
                new HomeMenuItem { Id = MenuItemType.About, Title = "О программе" }
                    );
            }

            menuItems.Add(
                new HomeMenuItem { Id = MenuItemType.Login, Title = "Вход" }
                    );

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}