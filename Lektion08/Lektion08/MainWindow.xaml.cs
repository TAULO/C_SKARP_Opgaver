using Lektion08.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Lektion08
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DatabaseContext context;
        public MainWindow()
        {
            InitializeComponent();
            context = new DatabaseContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(Car c in context.Cars)
            {
                MessageBox.Show(c.ToString());
            }   
        }
    }
}
