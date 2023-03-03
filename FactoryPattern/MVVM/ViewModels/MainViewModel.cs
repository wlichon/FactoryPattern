using FactoryPattern.Models;
using FactoryPattern.MVVM.Models.MyListItems;
using ModernDesign.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace FactoryPattern.MVVM.ViewModels
{
    public class MainViewModel
    {
        private ObservableCollection<ListViewItem> _myItems;

        public ObservableCollection<ListViewItem> MyItems
        {
            get { return _myItems;  }
        }

        private void AddItemToList(IListItemFactory factory)
        {
            MyItems.Add(factory.CreateItem());
        }


        public RelayCommand BlueItemButton { get; set; }

        public RelayCommand RedItemButton { get; set; }

        public MainViewModel()
        {
            _myItems = new ObservableCollection<ListViewItem>();

            BlueItemButton = new RelayCommand(o =>
            {
                AddItemToList(new BlueItemFactory());
            });

            RedItemButton = new RelayCommand(o =>
            {
                AddItemToList(new RedItemFactory());
            });
        }
    }
}
