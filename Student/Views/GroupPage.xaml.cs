using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Student.Models;
using Xamarin.Forms;

namespace Student.Views
{
    public partial class GroupPage : ContentPage
    {
        List<GroupItem> groupItems;
        public GroupPage()
        {
            InitializeComponent();
            Title = "Группы";
            groupItems = new List<GroupItem>
            {
                new GroupItem {Id = 1, Title="101" },
                new GroupItem { Id = 2, Title = "201" },
                new GroupItem { Id = 3, Title = "301" },
                new GroupItem { Id = 4, Title = "401" },
                new GroupItem { Id = 5, Title = "402" },
            };
            ListViewGroup.ItemsSource = groupItems;
            InitSearch();
        }

        private void InitSearch()
        {
            groupSearch.TextChanged += (s, e) => FilterItem(groupSearch.Text);
            groupSearch.SearchButtonPressed += (s, e) => FilterItem(groupSearch.Text);
        }

        private void FilterItem(string text)
        {
            ListViewGroup.BeginRefresh();
            if (string.IsNullOrWhiteSpace(text))
            {
                ListViewGroup.ItemsSource = groupItems;
            }
            else
            {
                ListViewGroup.ItemsSource = groupItems.Where(w=>w.Title.ToLower().Contains(text.ToLower() ));
            }
            ListViewGroup.EndRefresh();
        }

    }
}
