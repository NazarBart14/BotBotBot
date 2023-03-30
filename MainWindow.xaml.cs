using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace BotBotBot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> MessagesListBoxItem;
        private ObservableCollection<string> HistoryListBoxItem;

        public MainWindow()
        {
            InitializeComponent();

            MessagesListBoxItem = new ObservableCollection<string>();
            HistoryListBoxItem = new ObservableCollection<string>();

            MessagesListBox.ItemsSource = MessagesListBoxItem;
            HistoryListBox.ItemsSource = HistoryListBoxItem;
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string userInput = UserInputTextBox.Text;

            // Add user input to the list of messages
            AddMessage("You", userInput);

            // TODO: Send user input to the bot and get bot's response

            string botResponse = "Bot's response";

            // Add bot response to the list of messages
            AddMessage("Bot", botResponse);

            // Clear user input
            UserInputTextBox.Text = "";
        }

        private void AddMessage(string sender, string message)
        {
            string formattedMessage = string.Format("{0}: {1}", sender, message);

            MessagesListBoxItem.Add(formattedMessage);

            // Scroll to the bottom of the listbox to show the latest message
            MessagesListBox.ScrollIntoView(MessagesListBoxItem[MessagesListBoxItem.Count - 1]);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Loop through the selected items in MessagesListBox
            foreach (string selectedItem in MessagesListBox.SelectedItems)
            {
                // Add the selected item to the HistoryListBoxItem collection
                HistoryListBoxItem.Add(selectedItem);
            }

            // Refresh the display of the HistoryListBox
            HistoryListBox.Items.Refresh();

            // Remove the selected items from the MessagesListBoxItem collection
            while (MessagesListBox.SelectedItems.Count > 0)
            {
                MessagesListBoxItem.Remove((string)MessagesListBox.SelectedItems[0]);
            }
        }

    }
}
