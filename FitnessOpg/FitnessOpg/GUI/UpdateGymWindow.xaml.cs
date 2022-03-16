using FitnessOpg.Controller;
using FitnessOpg.Database;
using FitnessOpg.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FitnessOpg.GUI
{
    /// <summary>
    /// Interaction logic for AddGymWindow.xaml
    /// </summary>
    public partial class UpdateGymWindow : Window
    {
        Fitnesscenter f;
        GymContext context = new GymContext();
        public UpdateGymWindow()
        {
            InitializeComponent();
            Clear();

            if (MainWindow.Instance != null)
            {
                f = MainWindow.Instance.ListBoxGyms.SelectedItem as Fitnesscenter;
                this.DataContext = f;
            }
        }

        private void UpdateGym_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = textName.Text;
                string price = textPrice.Text;
                string dOpen = openingTimeText.Text;
                string dClose = closingTimeTxt.Text;

                if (price.Length >= 1 && dOpen.Length == 5 && dClose.Length == 5)
                {
                    if (MessageBox.Show("Are you sure you want to update " + name + "?", "Update Gym", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        Create c = new Create();
                        c.Updatefitnesscenter(f, name, double.Parse(price), ParseOpenHours(), ParseClosingHours());
                        context.SaveChanges();
                        Clear();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Fill every input field correctly", "Error", MessageBoxButton.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }
        }

        private DateTime ParseOpenHours()
        {
            DateTime dOpen = new DateTime();
            try
            {
                dOpen = DateTime.Parse(openingTimeText.Text);
                int dOpenHours = dOpen.Hour;
                int dOpenMinutes = dOpen.Minute;
                dOpen = new DateTime(2200, 1, 1, dOpenHours, dOpenMinutes, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }
            return dOpen;
        }

        private DateTime ParseClosingHours()
        {
            DateTime dClose = new DateTime();

            try
            {
                dClose = DateTime.Parse(closingTimeTxt.Text);
                int dCloseMinutes = dClose.Minute;
                int dCloseHours = dClose.Hour;
                dClose = new DateTime(2200, 1, 1, dCloseHours, dCloseMinutes, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }
            return dClose;
        }



        private void TextBoxNumeric_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9:]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TextBoxWords_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = !regex.IsMatch(e.Text);
        }

        private void Clear()
        {
            textName.Text = textPrice.Text = openingTimeText.Text = closingTimeTxt.Text = "";
        }

        private void DeleteGym_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete " + f.FitnessName + "?", "Delete Gym", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
            {
                var gym = context.FitnesscenterSet.SingleOrDefault(g => g.ID == f.ID);
                if (gym != null)
                {
                    context.FitnesscenterSet.Remove(gym);
                    MessageBox.Show(gym.FitnessName + " was successfully removed!", "Removed", MessageBoxButton.OK);
                    context.SaveChanges();
                    Clear();
                    this.Close();
                }
            }
        }
    }
}
