using DropdownMenu.Models.DropdownModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace DropdownMenu.UserControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DropMenu
    {
        public static readonly BindableProperty HeaderTextProperty =
       BindableProperty.Create(nameof(HeaderText), typeof(string), typeof(DropMenu), string.Empty, BindingMode.TwoWay);
        public static readonly BindableProperty HeaderTextColorProperty =
            BindableProperty.Create(nameof(HeaderTextColor), typeof(Color), typeof(DropMenu), Color.White, BindingMode.TwoWay);
       public static readonly BindableProperty ListSourceProperty =
            BindableProperty.Create(nameof(ListSource), typeof(IEnumerable), typeof(DropMenu), null, BindingMode.TwoWay);
        public static readonly BindableProperty ItemCheckedCommandProperty =
            BindableProperty.Create(nameof(ItemCheckedCommand), typeof(ICommand), typeof(DropMenu));
        public static readonly BindableProperty ColorBackgroundProperty =
            BindableProperty.Create(nameof(ColorBackground), typeof(Color), typeof(DropMenu), Color.White, BindingMode.TwoWay);
        public static readonly BindableProperty ListTextColorProperty =
          BindableProperty.Create(nameof(ListTextColor), typeof(Color), typeof(DropMenu), Color.White, BindingMode.TwoWay);
       
        public string HeaderText
        {
            get
            {
                return (string)GetValue(HeaderTextProperty);
            }
            set
            {
                if (value != null)
                    SetValue(HeaderTextProperty, value);
            }
        }
        public Color HeaderTextColor
        {
            get
            {
                return (Color)GetValue(HeaderTextColorProperty);
            }
            set
            {
                SetValue(HeaderTextColorProperty, value);
            }
        }
        public Color ColorBackground
        {
            get
            {
                return (Color)GetValue(ColorBackgroundProperty);
            }
            set
            {
                SetValue(ColorBackgroundProperty, value);
            }
        }
        public Color ListTextColor
        {
            get
            {
                return (Color)GetValue(ListTextColorProperty);
            }
            set
            {
                SetValue(ListTextColorProperty, value);
            }
        }
        public IEnumerable ListSource
        {
            get
            {
                return (IEnumerable)GetValue(ListSourceProperty);
            }
            set
            {
                if (value != null)
                {
                    SetValue(ListSourceProperty, value);
                }
            }
        }
        public ICommand ItemCheckedCommand
        {
            get { return (ICommand)GetValue(ItemCheckedCommandProperty); }
            set { SetValue(ItemCheckedCommandProperty, value); }
        }
        public DropMenu()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (!BottomStack.IsVisible)
            {
                BottomStack.IsVisible = true;
                headerImage.Source = "ExpanderClose.png";
            }
            else
            {
                BottomStack.IsVisible = false;
                headerImage.Source = "ExpanderOpen.png";
            }
        }

    }
}