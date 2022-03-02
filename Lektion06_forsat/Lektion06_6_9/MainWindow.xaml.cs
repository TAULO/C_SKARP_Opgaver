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

namespace Lektion06_6_9
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

        private void AddItems_Left(object sender, RoutedEventArgs e)
        {
            if (textBoxLeft.Text.Length >= 1)
            {
                listBoxLeft.Items.Add(textBoxLeft.Text);
                textBoxLeft.Clear();
            }
        }

        private void AddItems_Right(object sender, RoutedEventArgs e)
        {
            if (textBoxRigth.Text.Length >= 1)
            {
                listBoxRigth.Items.Add(textBoxRigth.Text);
                textBoxRigth.Clear();
            }
        }

        private void SwapItems_Right(object sender, RoutedEventArgs e)
        {
            if (listBoxLeft.Items.Count > 0)
            {
                foreach (var item in listBoxLeft.Items)
                {
                    listBoxRigth.Items.Add(item);
                }
                listBoxLeft.Items.Clear();
            } 
        }

        private void SwapItems_Left(object sender, RoutedEventArgs e)
        {
            foreach(var item in listBoxRigth.Items)
            {
                listBoxLeft.Items.Add(item);
            }
            listBoxRigth.Items.Clear();
        }

        private void Clear_Left(object sender, RoutedEventArgs e)
        {
            listBoxLeft.Items.Clear();
        }

        private void Clear_Right(object sender, RoutedEventArgs e)
        {
            listBoxRigth.Items.Clear();
        }
    }
}
