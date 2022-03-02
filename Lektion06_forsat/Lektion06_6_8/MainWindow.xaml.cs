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

namespace Lektion06_6_8
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

        Label labelLemon;
        Label labelOrange;
        Label labelBanana;
        Label labelApple;
        private void CheckBox_Checked_Lemon(object sender, RoutedEventArgs e)
        {
            var currCheckbox = e.Source as CheckBox;
            labelLemon = new Label();
            if (currCheckbox != null)
                labelLemon.Content = currCheckbox.Content;
                stackPanelCheckboxes.Children.Add(labelLemon);
        }

        private void CheckBox_Checked_Orange(object sender, RoutedEventArgs e)
        {
            var currCheckbox = e.Source as CheckBox;
            labelOrange = new Label();
            if (currCheckbox != null)
                labelOrange.Content = currCheckbox.Content;
                stackPanelCheckboxes.Children.Add(labelOrange);
        }

        private void CheckBox_Checked_Banana(object sender, RoutedEventArgs e)
        {
            var currCheckbox = e.Source as CheckBox;
            labelBanana = new Label();
            if (currCheckbox != null)
                labelBanana.Content = currCheckbox.Content;
                stackPanelCheckboxes.Children.Add(labelBanana);
        }

        private void CheckBox_Checked_Apple(object sender, RoutedEventArgs e)
        {
            var currCheckbox = e.Source as CheckBox;
            labelApple = new Label();
            if (currCheckbox != null)
                labelApple.Content = currCheckbox.Content;
                stackPanelCheckboxes.Children.Add(labelApple);
        }

        private void CheckBox_Unchecked_Lemon(object sender, RoutedEventArgs e)
        {
            stackPanelCheckboxes.Children.Remove(labelLemon);
        }

        private void CheckBox_Unchecked_Orange(object sender, RoutedEventArgs e)
        {
            stackPanelCheckboxes.Children.Remove(labelOrange);
        }

        private void CheckBox_Unchecked_Banana(object sender, RoutedEventArgs e)
        {
            stackPanelCheckboxes.Children.Remove(labelBanana);
        }

        private void CheckBox_Unchecked_Apple(object sender, RoutedEventArgs e)
        {
            stackPanelCheckboxes.Children.Remove(labelApple);
        }

        Label radioLabel;

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var currRadioBtn = e.Source as RadioButton; 
            if (currRadioBtn != null)
            {
                radioLabel = new Label();
                radioLabel.Content = currRadioBtn.Content;
                stackPanelRadio.Children.Add(radioLabel);
            }
        }

        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            stackPanelRadio.Children.Remove(radioLabel);
        }
    }
}
