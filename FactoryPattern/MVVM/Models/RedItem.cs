using FactoryPattern.Models;
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
    internal class RedItem : ListViewItem
    {
        public RedItem()
        {
            Background = Brushes.Red;
            Content = "Red Item";
          
        }
    }
}
