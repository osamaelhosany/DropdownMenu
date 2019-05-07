using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DropdownMenu.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private bool _started;

        public event PropertyChangedEventHandler PropertyChanged;

        protected BaseViewModel()
        {
            Title = string.Empty;
        }

        public bool IsVisible { get; private set; }
        public bool IsBusy { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }



        public virtual void OnAppearing()
        {
            IsVisible = true;

            if (!_started)
            {
                _started = true;
            }
        }

        public virtual void OnDisappearing()
        {
            IsVisible = false;
        }

        public virtual bool OnBackButtonPressed()
        {
            return false;
        }
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
