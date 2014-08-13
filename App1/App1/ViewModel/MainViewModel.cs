using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Model;

namespace App1.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            Items = new ObservableCollection<Item>(new[]
            {
                new Item{Name = "Item 1", Description = "Item 1 Description"},
                new Item{Name = "Item 2", Description = "Item 2 Description"},
                new Item{Name = "Item 3", Description = "Item 3 Description"},
                new Item{Name = "Item 4", Description = "Item 4 Description"},
            });
        }

        public ObservableCollection<Item> Items { get; set; }

    }
}
