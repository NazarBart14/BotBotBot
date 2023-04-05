using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using Microsoft.Data.SqlClient;


namespace BotBotBot
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

        private void LookingButton_Click(object sender, RoutedEventArgs e)
        {
            LookingWindow lookingWindow = new LookingWindow();
            lookingWindow.Owner = this;
            lookingWindow.Show();
        }

        private void LookedButton_Click(object sender, RoutedEventArgs e)
        {
            LookingWindow lookingWindow = new LookingWindow();
            lookingWindow.Owner = this;
            lookingWindow.Show();
        }

        private void PlanningButton_Click(object sender, RoutedEventArgs e)
        {
            LookingWindow lookingWindow = new LookingWindow();
            lookingWindow.Owner = this;
            lookingWindow.Show();
        }
    }
}
