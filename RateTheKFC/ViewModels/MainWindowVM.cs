using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RateTheKFC.ViewModels
{
    public class MainWindowVM : INotifyPropertyChanged {
        private string _searchQuery = string.Empty;
        public string SearchQuery { 
            get { return _searchQuery; }
            set { 
                _searchQuery = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? name = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
