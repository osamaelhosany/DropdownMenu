using DropdownMenu.Models.DropdownModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DropdownMenu.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public DropMenuModel DemoData { get; set; }
        public DropMenuModel DemoData1 { get; set; }
        public ICommand ItemCheckedCommand { get; set; }
        public MainViewModel()
        {
            DemoData = new DropMenuModel
            {
                Id = 1,
                HeaderName = "Gender",
                DropMenuList = new ObservableCollection<DropMenuItemModel>
                    {
                        new DropMenuItemModel
                        {
                            Id = 1,
                            Name = "Male",
                            IsSelected = false,
                        },
                        new DropMenuItemModel
                        {
                            Id = 2,
                            Name = "Female",
                            IsSelected = false,
                        },
                        new DropMenuItemModel
                        {
                            Id = 3,
                            Name = "Other",
                            IsSelected = false,
                        },
                    }
            };
            DemoData1 = new DropMenuModel
            {
                Id = 1,
                HeaderName = "Looking for",
                DropMenuList = new ObservableCollection<DropMenuItemModel>
                    {
                        new DropMenuItemModel
                        {
                            Id = 1,
                            Name = "Man",
                            IsSelected = false,
                        },
                        new DropMenuItemModel
                        {
                            Id = 2,
                            Name = "Woman",
                            IsSelected = false,
                        },
                        new DropMenuItemModel
                        {
                            Id = 3,
                            Name = "Friend",
                            IsSelected = false,
                        },
                    }
            };
            ItemCheckedCommand = new Command(ItemCheckedCommandExecute);
        }

        private void ItemCheckedCommandExecute(object obj)
        {
            //do what ever you want 
        }
    }
}
