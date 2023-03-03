using FactoryPattern.MVVM.Models.MyListItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FactoryPattern.Models
{
    interface IListItemFactory
    {
        ListViewItem CreateItem();

        
    }

    class RedItemFactory : IListItemFactory
    {
        public ListViewItem CreateItem()
        {
            return new RedItem();
        }
    }

    class BlueItemFactory : IListItemFactory
    {
        public ListViewItem CreateItem()
        {
            return new BlueItem();
        }
    }

}
