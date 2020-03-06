using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaterial.Views;

namespace TestMaterial.Models
{
    public class MainModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<MenuItem> _allItems;
        private ObservableCollection<MenuItem> _menuItems;
        private MenuItem _selectedItem;



        public MainModel()
        {
            _allItems = GenerateMenu();
            MenuItems = _allItems;
        }


        public ObservableCollection<MenuItem> MenuItems
        {
            get => _menuItems;
            set { _menuItems = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MenuItems))); }
        }


        public MenuItem SelectedItem
        {
            get => _selectedItem;
            set 
            { 
                if (value == null || value.Equals(_selectedItem)) return;

                _selectedItem = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedItem)));
            }
        }



        private ObservableCollection<MenuItem> GenerateMenu()
        {
            ObservableCollection<MenuItem> menu = new ObservableCollection<MenuItem>();

            menu.Add(new MenuItem("First", new UC1()));

            return menu;
        }
    }
}
