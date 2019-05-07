using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DropdownMenu.Models.DropdownModel
{
    public class DropMenuModel : BaseEntity
    {
        public string HeaderName { get; set; }
        public ObservableCollection<DropMenuItemModel> DropMenuList { get; set; }
    }
    public class DropMenuItemModel : BaseEntity
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }
}
