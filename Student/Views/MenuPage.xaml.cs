﻿using Student.Models;
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
                new HomeMenuItem { Id = MenuItemType.Ads, Title = "Объявления" },
                new HomeMenuItem { Id = MenuItemType.Enrollee, Title = "Абитуриенту" },
                new HomeMenuItem { Id = MenuItemType.Student, Title = "Студенту" },
                new HomeMenuItem { Id = MenuItemType.Schedule, Title = "Расписание" },
                new HomeMenuItem { Id = MenuItemType.About, Title = "Контакты" },
                new HomeMenuItem { Id = MenuItemType.Login, Title = "Ссылки" }
            };

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