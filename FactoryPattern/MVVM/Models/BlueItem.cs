using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FactoryPattern.MVVM.Models.MyListItems
{
    internal class BlueItem : ListViewItem
    {
        public BlueItem()
        {
            Background = Brushes.Blue;
            Content = "Blue Item";
        }
    }
}
