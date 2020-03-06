using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TestMaterial.Extensions;

namespace TestMaterial.Models
{
    public class MenuItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        private object _content;
        private ScrollBarVisibility _horizontalScrollBarVisibilityRequirement;
        private ScrollBarVisibility _verticalScrollBarVisibilityRequirement;
        private Thickness _marginRequirement = new Thickness(16);


        public MenuItem(string name, object content)
        {
            _name = name;
            _content = content;
        }


        public string Name 
        { 
            get => _name; 
            set => this.MutateVerbose(ref _name, value, RaisePropertyChanged()); 
        }

        public object Content 
        { 
            get => _content; 
            set => this.MutateVerbose(ref _content, value, RaisePropertyChanged()); 
        }

        public ScrollBarVisibility HorizontalScrollBarVisibilityRequirement 
        { 
            get => _horizontalScrollBarVisibilityRequirement; 
            set => this.MutateVerbose(ref _horizontalScrollBarVisibilityRequirement, value, RaisePropertyChanged()); 
        }

        public ScrollBarVisibility VerticalScrollBarVisibilityRequirement 
        { 
            get => _verticalScrollBarVisibilityRequirement;
            set => this.MutateVerbose(ref _verticalScrollBarVisibilityRequirement, value, RaisePropertyChanged());
        }

        public Thickness MarginRequirement 
        { 
            get => _marginRequirement;
            set => this.MutateVerbose(ref _marginRequirement, value, RaisePropertyChanged());
        }

        private Action<PropertyChangedEventArgs> RaisePropertyChanged()
        {
            return args => PropertyChanged?.Invoke(this, args);
        }
    }
}
