using FitnessOpg.Database;
using FitnessOpg.Model;
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
        public MainWindow()
        {
            InitializeComponent();
            //InitList();
            Instance = this;
            UpdateLists();

            // det skal fikses!
            // ListBoxMembers.DataContext = context.MemberSet.ToList();

   
        }

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

        private void InitList()
        {
            Fitnesscenter fSkjern = new Fitnesscenter("Fitness Skjern", 150, new DateTime(2200, 1, 1, 5, 0, 0), new DateTime(2200, 1, 1, 22, 0, 0));
            Fitnesscenter fAarhus = new Fitnesscenter("Fitness Aarhus", 200, new DateTime(2200, 1, 1, 5, 0, 0), new DateTime(2200, 1, 1, 23, 0, 0));
            Fitnesscenter fKøbenhavn = new Fitnesscenter("Fitness København", 250, new DateTime(2200, 1, 1, 5, 0, 0), new DateTime(2200, 1, 1, 23, 0, 0));

            Member claus = new Member("Claus", new DateTime(1995, 2, 5), "claus@gmail.com");
            claus.FitnesscenterList.Add(fKøbenhavn);
            claus.FitnesscenterList.Add(fAarhus);
            claus.FitnesscenterList.Add(fSkjern);
            fSkjern.Members.Add(claus);
            fAarhus.Members.Add(claus);
            fKøbenhavn.Members.Add(claus);

            Member tobias = new Member("Tobias", new DateTime(1995, 1, 3), "Tobias@gmail.com");
            tobias.FitnesscenterList.Add(fKøbenhavn);
            tobias.FitnesscenterList.Add(fAarhus);
            tobias.FitnesscenterList.Add(fSkjern);
            fSkjern.Members.Add(tobias);
            fAarhus.Members.Add(tobias);
            fKøbenhavn.Members.Add(tobias);

            Member trine = new Member("Trine", new DateTime(2001, 1, 3), "Trine@gmail.com");
            trine.FitnesscenterList.Add(fKøbenhavn);
            trine.FitnesscenterList.Add(fAarhus);
            trine.FitnesscenterList.Add(fSkjern);
            fSkjern.Members.Add(trine);
            fAarhus.Members.Add(trine);
            fKøbenhavn.Members.Add(trine);

            Member liam = new Member("Liam", new DateTime(1981, 10, 9), "Liam@gmail.com");
            liam.FitnesscenterList.Add(fKøbenhavn);
            liam.FitnesscenterList.Add(fAarhus);
            liam.FitnesscenterList.Add(fSkjern);
            fSkjern.Members.Add(liam);
            fAarhus.Members.Add(liam);
            fKøbenhavn.Members.Add(liam);

            Member noah = new Member("Noah", new DateTime(2003, 3, 1), "Noah@gmail.com");
            noah.FitnesscenterList.Add(fKøbenhavn);
            noah.FitnesscenterList.Add(fAarhus);
            fAarhus.Members.Add(noah);
            fKøbenhavn.Members.Add(noah);

            Member oliver = new Member("Oliver", new DateTime(1980, 10, 9), "Oliver@gmail.com");
            oliver.FitnesscenterList.Add(fKøbenhavn);
            oliver.FitnesscenterList.Add(fAarhus);
            fAarhus.Members.Add(oliver);
            fKøbenhavn.Members.Add(oliver);

            Member william = new Member("Willaim", new DateTime(2000, 3, 8), "William@gmail.com");
            william.FitnesscenterList.Add(fKøbenhavn);
            fKøbenhavn.Members.Add(william);

            Member james = new Member("James", new DateTime(1989, 1, 1), "James@gmail.com");
            james.FitnesscenterList.Add(fKøbenhavn);
            fKøbenhavn.Members.Add(james);

            Member benjamin = new Member("Benjamin", new DateTime(1992, 5, 10), "Benjamin@gmail.com");
            benjamin.FitnesscenterList.Add(fKøbenhavn);
            fKøbenhavn.Members.Add(benjamin);

            Member lucas = new Member("Lucas", new DateTime(1993, 10, 5), "Lucas@gmail.com");
            lucas.FitnesscenterList.Add(fKøbenhavn);
            fKøbenhavn.Members.Add(lucas);

            Member henry = new Member("Henry", new DateTime(1977, 1, 2), "Henry@gmail.com");
            henry.FitnesscenterList.Add(fAarhus);
            fAarhus.Members.Add(oliver);

            Member alexander = new Member("Alexander", new DateTime(1990, 2, 5), "Alexander@gmail.com");
            alexander.FitnesscenterList.Add(fSkjern);
            fSkjern.Members.Add(alexander);
        }

        private void RefreshListBoxes_Click(object sender, RoutedEventArgs e)
        {
            UpdateLists();
        }
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
        private void UpdateLists()
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
                UpdateLists();
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
                UpdateLists();
            }
        }
        private void ListBoxMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Member selectedMember = ListBoxMembers.SelectedItem as Member;

            //Console.WriteLine(selectedMember);

            //if (selectedMember != null && selectedMember.FitnesscenterList.Count > 0)
            //{
            //    ListBoxGyms.Items.Clear();
            //    foreach (var gym in selectedMember.FitnesscenterList)
            //    {
            //        ListBoxGyms.Items.Add(gym);
            //    }
            //}
            //ListBoxGyms.Items.Clear();
        }
    }
}
