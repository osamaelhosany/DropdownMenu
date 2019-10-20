using DropdownMenu.Models.DropdownModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace DropdownMenu.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public DropMenuModel GenderList { get; set; }
        public DropMenuModel LookingforList { get; set; }
        public ICommand GenderSelectedCommand { get; set; }
        public ICommand LookingforListCommand { get; set; }
        public MainViewModel()
        {
            GenderList = new DropMenuModel
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
            LookingforList = new DropMenuModel
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
            GenderSelectedCommand = new Command(GenderSelectedCommandExecute);
            LookingforListCommand = new Command(LookingforListCommandExecute);
        }

        private void GenderSelectedCommandExecute(object obj)
        {
            //first we set all is selected == false then we set new value
            //GenderList.DropMenuList.Select(x => { x.IsSelected = false; return x; }).ToList();

            //if (obj is DropMenuItemModel selecteditem)
            //    GenderList.DropMenuList.FirstOrDefault(x => x.Id == selecteditem.Id).IsSelected = true;
        }
        private void LookingforListCommandExecute(object obj)
        {

        }
    }
}
