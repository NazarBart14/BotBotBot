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
    /// Логика взаимодействия для LookingWindow.xaml
    /// </summary>
    public partial class LookingWindow : Window
    {
        public LookingWindow()
        {
            InitializeComponent();
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AllMoviePerson;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                string query = "SELECT * FROM Looking";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);

                            Console.WriteLine("{0}\t{1}", id, name);

                        }
                    }
                }
            }
        }
    }
}
