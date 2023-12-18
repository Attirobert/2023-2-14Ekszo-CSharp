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
using MySql.Data.MySqlClient;
using System.Data;

namespace WpfMySql_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Osztályváltozók
        private string connectionString = "Server='localhost'; Database='wpfmysql'; User Id='root'; Password='';";
        private DataTable dataTable = new DataTable();
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Adatbázis megnyitása, adatok lekérése, gridhez kötés
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Persons";

                    // Előállítjuk az objektumot, amely eléri a az adatbázist és a táblát
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Az adapter tudja lekérdezni az adatokat
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    // A dataTable objektumba az adapter feltölti az adatokat
                    dataTable.Clear();
                    adapter.Fill(dataTable);

                    // A dataTable-t hozzákapcsoljuk a gridhez
                    dataGrid.ItemsSource = dataTable.DefaultView;
                }
                catch (Exception e)
                {

                    MessageBox.Show($"Hiba a betöltés közben: {e.Message}");
                }
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            string name = txbName.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"INSERT INTO persons (Name) VALUES ('{name}')";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    LoadData();
                }
                catch (Exception ex)
                {

                   MessageBox.Show($"Hiba a beszúrás közben: {ex.Message}");
                }
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = dataGrid.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                // A kijelölt sorból kiszedem az adatokat
                int id = Convert.ToInt32(selectedRow["ID"]);
                string name = txbName.Text;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "UPDATE persons SET Name = @Name WHERE ID = @ID";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@ID", id);

                        cmd.ExecuteNonQuery();

                        LoadData();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Hiba a frissítés közben: {ex.Message}");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = dataGrid.SelectedItem as DataRowView;

            if (selectedRow != null)
            {
                int id = Convert.ToInt32(selectedRow["ID"]);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM persons WHERE ID = @ID";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@ID", id);

                        cmd.ExecuteNonQuery();

                        LoadData();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Hiba a törlés közben: {ex.Message}");
                    }
                }
            }
        }
    }
}
