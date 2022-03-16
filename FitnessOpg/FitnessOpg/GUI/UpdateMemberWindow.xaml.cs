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
    /// Interaction logic for UpdateMemberWindow.xaml
    /// </summary>
    public partial class UpdateMemberWindow : Window
    {
        Member updateMember;
        string birth;
        GymContext context = new GymContext();
        public UpdateMemberWindow()
        {
            InitializeComponent();
            Clear();
            if (MainWindow.Instance != null)
            {
                updateMember = MainWindow.Instance.ListBoxMembers.SelectedItem as Member;
                this.DataContext = updateMember;
            }
        }

        private void UpdateMemberBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = TextBoxName.Text;
                birth = TextBoxBirth.Text;
                string mail = TextBoxMail.Text;
                string dBirth = TextBoxBirth.Text;

                if (name != null && name.Length > 1 &&
                    birth != null && birth.Length > 1 &&
                    mail != null && mail.Length > 1 &&
                    dBirth != null && dBirth.Length <= TextBoxBirth.MaxLength)
                {
                    if (MessageBox.Show("Are you sure you want to update: " + updateMember.MemberName + "?", "Update Member", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        var memberFound = context.MemberSet.SingleOrDefault(m => m.MemberID == updateMember.MemberID);
                        if (memberFound != null)
                        {
                            memberFound.MemberName = name;
                            memberFound.MemberMail = mail;
                            memberFound.MemberBirth = ParseBirth();
                            context.SaveChanges();
                        }
                        Clear();
                    }
                } 
            } 
            catch (Exception ex)
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
                updateMember.MemberBirth = birthParsed;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }
            return birthParsed;
        }

        private void BirthControlClick(object sender, RoutedEventArgs e)
        {
            ParseBirth();
            if (updateMember.IsOver16())
            {
                CheckboxOver16.IsChecked = true;
                UpdateMemberBtn.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("The member has to be over the age of 16", "Error", MessageBoxButton.OK);
                CheckboxOver16.IsChecked = false;
                UpdateMemberBtn.IsEnabled = false;
            }
        }

        private void Clear()
        {
            TextBoxName.Text = TextBoxMail.Text = TextBoxBirth.Text = "";
            UpdateMemberBtn.IsEnabled = false;
            CheckboxOver16.IsEnabled = false;
            CheckboxOver16.IsChecked = false;
        }

        private void DeleteMemberBtn_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to remove: " + updateMember.MemberName + "?", "Delete Member", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
            {
                var memberFound = context.MemberSet.SingleOrDefault(m => m.MemberID == updateMember.MemberID);
                if(memberFound != null)
                {
                    context.MemberSet.Remove(memberFound);
                    context.SaveChanges();
                    MessageBox.Show(memberFound.MemberName + " was succesfully removed!", "Removed", MessageBoxButton.OK);
                    this.Close();
                }
            }
        }
        private void TextBoxBirth_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9/]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TextBoxName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = !regex.IsMatch(e.Text);
        }

        private void AddMemberToGymBtn_Click(object sender, RoutedEventArgs e)
        {
            AddMemberToGym win = new AddMemberToGym(updateMember);
            win.Show();
        }
    }
}
