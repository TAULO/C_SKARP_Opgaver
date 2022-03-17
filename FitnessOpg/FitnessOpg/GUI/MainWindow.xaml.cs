using FitnessOpg.Database;
using FitnessOpg.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
// Det skal helts hedde view i stedet for gui, men det fandt jeg ud af ret sent
namespace FitnessOpg.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GymContext context = new GymContext();
        public static MainWindow Instance { get; private set; }
        public ObservableCollection<Fitnesscenter> Fitnesscenters { get; private set; }
        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
            UpdateListBoxes();
        }

        // -------------------------------------------------------- windows -------------------------------------------------------
        private void AddGymClick(object sender, RoutedEventArgs e)
        {
            AddGymWindow win = new AddGymWindow();
            win.Show();
        }

        private void AddMemberClick(object sender, RoutedEventArgs e)
        {
            AddMemberWindow win = new AddMemberWindow();
            win.Show();
        }

        private void ListBoxMembers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            UpdateMemberWindow win = new UpdateMemberWindow();
            win.Show();
        }
        private void ListBoxGyms_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            UpdateGymWindow win = new UpdateGymWindow();
            win.Show();
        }

        private void RefreshListBoxes_Click(object sender, RoutedEventArgs e)
        {
            UpdateListBoxes();
        }
        private void UpdateListBoxes()
        {
            ListBoxGyms.Items.Clear();
            foreach (var item in context.FitnesscenterSet)
            {
                ListBoxGyms.Items.Add(item);
            }
            ListBoxMembers.Items.Clear();
            foreach (var item in context.MemberSet)
            {
                ListBoxMembers.Items.Add(item);
            }
        }

        // -------------------------------------------------------- data filters -------------------------------------------------------
        private void SortFitnessAsc_Click(object sender, RoutedEventArgs e)
        {
            ListBoxGyms.Items.Clear();
            var result = context.FitnesscenterSet.OrderBy(f => f.FitnessName);

            foreach (var item in result)
            {
                ListBoxGyms.Items.Add(item);
            }
        }
        private void SortFitnessDesc_Click(object sender, RoutedEventArgs e)
        {
            ListBoxGyms.Items.Clear();
            var result = context.FitnesscenterSet.OrderByDescending(f => f.FitnessName);

            foreach (var item in result)
            {
                ListBoxGyms.Items.Add(item);
            }
        }
        private void SortMemberAsc_Click(object sender, RoutedEventArgs e)
        {
            ListBoxMembers.Items.Clear();
            var result = context.MemberSet.OrderBy(f => f.MemberName);

            foreach (var item in result)
            {
                ListBoxMembers.Items.Add(item);
            }
        }
        private void SortMemberDesc_Click(object sender, RoutedEventArgs e)
        {
            ListBoxMembers.Items.Clear();
            var result = context.MemberSet.OrderByDescending(f => f.MemberName);

            foreach (var item in result)
            {
                ListBoxMembers.Items.Add(item);
            }
        }

        private void FilterCityName(string name)
        {
            ListBoxGyms.Items.Clear();
            var result = context.FitnesscenterSet.Where(f => f.FitnessName == name);
            if (result.Any())
            {
                foreach (var item in result)
                {
                    ListBoxGyms.Items.Add(item);
                }
            }
        }

        private void FilterMemberName(string name)
        {
            ListBoxMembers.Items.Clear();
            var result = context.MemberSet.Where(m => m.MemberName == name);
            if (result.Any())
            {
                foreach (var item in result)
                {
                    ListBoxMembers.Items.Add(item);
                } 
            }
        }

        private void SearchMemberName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = SearchMemberName.Text;
            if (text != null && text.Length > 0)
            {
                FilterMemberName(text);
            } else
            {
                UpdateListBoxes();
            }
        }

        private void SearchGymName_TextChanged(object sender, TextChangedEventArgs e)
        {
            var text = SearchGymName.Text;
            if (text != null && text.Length > 0)
            {
                FilterCityName(text);
            } else
            {
                UpdateListBoxes();
            }
        }

        // show each gym this selected member is a member of
        private void ListBoxMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Member selectedMember = ListBoxMembers.SelectedItem as Member;
            if (selectedMember != null && selectedMember.FitnesscenterList.Count > 0)
            {
                ListBoxGyms.Items.Clear();
                foreach (var gym in selectedMember.FitnesscenterList)
                {
                    ListBoxGyms.Items.Add(gym);
                }
            } 
            else if (selectedMember != null && selectedMember.FitnesscenterList.Count <= 0)
            {
                ListBoxGyms.Items.Clear();
                ListBoxGyms.Items.Add(new Label().Content = "No gyms found");
            }
        }

        // show every member who are members of the selected gym
        private void ListBoxGyms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Fitnesscenter selectedGym = ListBoxGyms.SelectedItem as Fitnesscenter;
            if (selectedGym != null && selectedGym.Members.Count > 0)
            {
                ListBoxMembers.Items.Clear();
                foreach(var member in selectedGym.Members)
                {
                    ListBoxMembers.Items.Add(member);
                }
            } else if (selectedGym != null && selectedGym.Members.Count <= 0)
            {
                ListBoxMembers.Items.Clear();
                ListBoxMembers.Items.Add(new Label().Content = "No members found");
            }
        }
    }
}
