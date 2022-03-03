using Lektion07_1;
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

namespace Lektion07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person p;
        public MainWindow()
        {
            InitializeComponent();

            p = new Person("", 0.0, 0, 0, false);
            mainGrid.DataContext = p;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var name = textBoxName.Text;
            var weigth = textBoxWeigth.Text;
            var age = textBoxAge.Text;
            var score = textBoxScore.Text;
            bool accepted = false;
            p = new Person(name, double.Parse(weigth), int.Parse(age), int.Parse(score), accepted);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Trace.WriteLine(p.ToString());
        }
    }
}
