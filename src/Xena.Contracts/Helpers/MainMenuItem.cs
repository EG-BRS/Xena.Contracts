using System.Collections.Generic;

namespace Xena.Contracts.Helpers
{
    public class MenuItemChild
    {
        public string Description { get; set; }
        public string Url { get; set; }
        public string CssClass { get; set; }
        public bool IsPopup { get; set; }
    }
    public class MenuItem
    {
        public string Description { get; set; }
        public string Url { get; set; }
        public string CssClass { get; set; }
        public bool IsPopup { get; set; }
        public MenuItemChild[] Children { get; set; }
    }

    public class MainMenuItem
    {
        public string CssClass { get; set; }
        public string Description { get; set; }
        public IEnumerable<MenuItem> Items { get; set; }
    }

}