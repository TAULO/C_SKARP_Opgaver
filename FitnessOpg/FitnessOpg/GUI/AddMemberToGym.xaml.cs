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
            gymArr = context.FitnesscenterSet.ToArray();
            for (int i = 0; i < context.FitnesscenterSet.Count(); i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Content = gymArr[i].FitnessName;

                stackPanel.Children.Add(checkBox);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckBox currItem;
            foreach(var child in stackPanel.Children)
            {
                if(child is CheckBox)
                {
                    currItem = child as CheckBox;
                    if (currItem.IsChecked == true)
                    {
                        Console.WriteLine(currItem.Content);
                    }
                }
            }
        }
    }
}
