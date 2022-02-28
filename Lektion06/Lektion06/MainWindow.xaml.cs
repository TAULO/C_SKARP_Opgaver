using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lektion06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ClickEvent(Object sender, RoutedEventArgs e)
        {
            // opgave 6.4
            if (checkBox.IsChecked == true)
            {
                topBtn.IsEnabled = false;
            } else
            {
                topBtn.IsEnabled = true;
            }

            // opgave 6.5
            var tempBatman = batman.Content;
            var tempRobin = robin.Content;

            batman.Content = hulk.Content;
            robin.Content = superman.Content;
            hulk.Content = tempBatman;
            superman.Content = tempRobin;
        }

        private void ClickEvent2(Object sender, RoutedEventArgs e)
        {
            // opgave 6.5
            var tempHulk = hulk.Content;
            var tempSuperman = superman.Content;

            hulk.Content = batman.Content;
            superman.Content = robin.Content;
            batman.Content = tempHulk;
            robin.Content = tempSuperman;
        }

    }
}
