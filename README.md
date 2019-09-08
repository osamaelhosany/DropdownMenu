# DropdownMenu
DropdownMenu - Xamarin forms (andriod & ios)Sample Control
## OverView
This control help you to show a dropdown menu to user in ios & andriod 
a quick way to select one value or multi from a set. a dropdown-menu shows its currently selected value. Touching the dropdown-menu header displays a dropdown menu with all other available values, from which the user can select a new one or multi.
## Getting Started
You can handle the way to make it multi choice or one value from command 
```
    private void GenderSelectedCommandExecute(object obj)
    {
        //first we set all is selected == false then we set new value
        GenderList.DropMenuList.Select(x => { x.IsSelected = false; return x; }).ToList();

        if (obj is DropMenuItemModel selecteditem)
            GenderList.DropMenuList.FirstOrDefault(x => x.Id == selecteditem.Id).IsSelected = true;
    }
 ```
## Screenshots
![alt text](https://github.com/osamaelhosany/DropdownMenu/blob/master/img/Screenshot_1.png)
![alt text](https://github.com/osamaelhosany/DropdownMenu/blob/master/img/Screenshot_2.png)
![alt text](https://github.com/osamaelhosany/DropdownMenu/blob/master/img/Screenshot_3.png)
![alt text](https://github.com/osamaelhosany/DropdownMenu/blob/master/img/Screenshot_4.png)

## My Controls
- [ImageEditor](https://github.com/osamaelhosany/ImageEditor-XamarinForms)
