using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Models
{
    public enum MenuItemType
    {
        Browse,
        Schedule,
        About,
        Group,
        Login
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
    public class GroupItem
    {
        public int Id { get; set; }

        public string Title { get; set; }
    }
}
