using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    class MainViewModel
    {
        public ObservableCollection<ConcertViewModel> ConcertsList { get; set; }

        public MainViewModel(List<Concert> concerts)
        {
            ConcertsList = new ObservableCollection<ConcertViewModel>(concerts.Select(b => new ConcertViewModel(b)));
        }
    }
}
