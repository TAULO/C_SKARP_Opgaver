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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lektion06_forsat
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

        private void ClickEvent(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string content = (sender as Button).Content.ToString();

            switch (content)
            {
                case "Vest":
                    textBox.AppendText("vest");
                    textBox.AppendText(Environment.NewLine);
                    break;
                case "Nord":
                    textBox.AppendText("Nord");
                    textBox.AppendText(Environment.NewLine);
                    break;
                case "Øst":
                    textBox.AppendText("Øst");
                    textBox.AppendText(Environment.NewLine);
                    break;
                case "Syd":
                    textBox.AppendText("Syd");
                    textBox.AppendText(Environment.NewLine);
                    break;
            }
        }
    } 
}
