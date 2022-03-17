using FitnessOpg.Database;
using FitnessOpg.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for AddMemberWindow.xaml
    /// </summary>
    public partial class AddMemberWindow : Window
    {
        Member newMember;
        string birth;
        GymContext context = new GymContext();

        public AddMemberWindow()
        {
            InitializeComponent();

            Clear();

            newMember = new Member("", new DateTime(1,1,1), "");
            this.DataContext = newMember;
        }
        private void AddMemberClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = TextBoxName.Text;
                birth = TextBoxBirth.Text;
                string mail = TextBoxMail.Text;

                if (name != null && name.Length > 1 &&
                    birth != null && birth.Length <= TextBoxBirth.MaxLength &&
                    mail != null && mail.Length > 1)
                {
                    if (MessageBox.Show("Are you sure you want to add: " + name + "?", "Add new Member", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        newMember = new Member(name, ParseBirth(), mail);
                        context.MemberSet.Add(newMember);
                        context.SaveChanges();
                        MessageBox.Show(newMember.MemberName + " has been added!", "Success", MessageBoxButton.OK);
                        Clear();
                    }
                    else
                    {
                        Clear();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }
        }
        private DateTime ParseBirth()
        {
            DateTime birthParsed = new DateTime();
            try
            {
                birth = TextBoxBirth.Text;
                var birthArr = birth.Split('/');
                int birtDayParsed = Convert.ToInt32(birthArr[0]);
                int birthMonthParsed = Convert.ToInt32(birthArr[1]);
                int birthYearParsed = Convert.ToInt32(birthArr[2]);
                birthParsed = new DateTime(birthYearParsed, birthMonthParsed, birtDayParsed);
                newMember.MemberBirth = birthParsed;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }
            return birthParsed;
        }

        private void BirthControlClick(object sender, RoutedEventArgs e)
        {
            ParseBirth();
            if (newMember.IsOver16())
            {
                CheckboxOver16.IsChecked = true;
                AddMemberBtn.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("The member has to be over the age of 16", "Error", MessageBoxButton.OK);
                CheckboxOver16.IsChecked = false;
                AddMemberBtn.IsEnabled = false;
            }
        }

        private void Clear()
        {
            TextBoxName.Text = TextBoxMail.Text = TextBoxBirth.Text = "";
            AddMemberBtn.IsEnabled = false;
            CheckboxOver16.IsEnabled = false;
            CheckboxOver16.IsChecked = false;
        }

        private void TextBoxBirth_TextChanged(object sender, TextChangedEventArgs e)
        {
            birth = TextBoxBirth.Text;
            Console.WriteLine(birth.Length);
            if (birth.Length == 2)
            {
                birth += "/";
            }
            if (birth.Length == 4)
            {
                birth += "/";
            }
            if (birth.Length >= 7)
            {

            }
            Console.WriteLine(birth);
        }
        // tillader kun numerisk værdier
        private void TextBoxBirth_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9/]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        // tillader kun bogstaver værdier 
        private void TextBoxName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = !regex.IsMatch(e.Text);
        }
    }
}
