using RateTheKFC.Models;
using RateTheKFC.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RateTheKFC.ViewModels
{
    public class MainWindowVM : INotifyPropertyChanged {
        private readonly CompanyService _companyService;

        public MainWindowVM(CompanyService companyService){
            _companyService = companyService;
            // obtain all cities
        }
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

        public ObservableCollection<Company> Companies { get; set; }

    }
}
