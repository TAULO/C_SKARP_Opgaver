using FitnessOpg.Database;
using FitnessOpg.Model;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace FitnessOpg.GUI
{
    /// <summary>
    /// Interaction logic for AddMemberToGym.xaml
    /// </summary>
    public partial class AddMemberToGym : Window
    {
        Member member;
        Fitnesscenter[] gymArr;

        GymContext context = new GymContext();
        public AddMemberToGym(Member m)
        {
            InitializeComponent();

            member = m;
            member = context.MemberSet.SingleOrDefault(mem => mem.MemberID == member.MemberID);

            gymArr = context.FitnesscenterSet.ToArray();
            for (int i = 0; i < gymArr.Length; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Content = gymArr[i].FitnessName;
                checkBox.Checked += CheckBox_Checked;
                checkBox.Unchecked += CheckBox_Unchecked;
                stackPanel.Children.Add(checkBox);
                if (member.FitnesscenterList.Contains(gymArr[i]))
                {
                    checkBox.IsChecked = true;
                } else
                {
                    checkBox.IsChecked = false;
                }
            }
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var currCheckbox = sender as CheckBox;
            listBox.Items.Add(currCheckbox.Content);
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            var currCheckbox = sender as CheckBox;
            listBox.Items.Remove(currCheckbox.Content);
            int indeks = stackPanel.Children.IndexOf(currCheckbox);
            member.FitnesscenterList.Remove(gymArr[indeks]);
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckBox currCheckbox = new CheckBox();
            Fitnesscenter[] currGym = new Fitnesscenter[gymArr.Length + 1];
            int indeks = -1;
            foreach(var child in stackPanel.Children)
            {
                if(child is CheckBox)
                {
                    currCheckbox = child as CheckBox;
                    if (currCheckbox.IsChecked == true)
                    {
                        int childIndeks = stackPanel.Children.IndexOf(currCheckbox);
                        indeks++;
                        currGym[indeks] = gymArr[childIndeks];
                    } else if (indeks > -1 && currCheckbox.IsChecked == false)
                    {
                        var remove = currGym.ToList();
                        remove.RemoveAt(indeks);
                    }
                }
            }
            if (currGym.Length > -1)
            {
                foreach(var gym in currGym)
                {
                    if (gym != null)
                    {
                        var fitnessFound = context.FitnesscenterSet.FirstOrDefault(f => f.ID == gym.ID);
                        member.FitnesscenterList.Add(fitnessFound);
                        fitnessFound.Members.Add(member);
                        context.SaveChanges();
                    }
                }
                //MessageBox.Show("You have added " + member.MemberName + " to:" + Environment.NewLine + currGym[indeks].FitnessName);
                this.Close();
            }
        }
    }
}
