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
    struct Params
    {
        public string paramName;
        public string paramValue;
    }

    public partial class MainWindow : Window
    {
        // Osztályváltozók
        private string connectionString = "Server='localhost'; Database='wpfmysql'; User Id='root'; Password='';";
        private DataTable dataTable = new DataTable();

        // Eljrás nevek
        private string teljesLista = "PersonsAll",
            insertPerson = "InsertPerson",
            updatePerson = "UpdatePerson",
            deletePerson = "DeletePerson";

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
                    string query = teljesLista;

                    // Előállítjuk az objektumot, amely eléri a az adatbázist és a táblát
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

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
            // Paraméter lista előállítása
            List<Params> pList = new List<Params>();
            Params ps;
            ps.paramName = "@pName";
            ps.paramValue = txbName.Text;
            pList.Add(ps);

            Dbproc(connectionString, insertPerson, pList);
            #region Régi insert
            // string name = txbName.Text;
            //using (MySqlConnection connection = new MySqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        string query = insertPerson;
            //        MySqlCommand cmd = new MySqlCommand(query, connection);
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@pName", name);
            //        cmd.ExecuteNonQuery();

            //        LoadData();
            //    }
            //    catch (Exception ex)
            //    {

            //       MessageBox.Show($"Hiba a beszúrás közben: {ex.Message}");
            //    }
            //}
            #endregion Régi insert
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = dataGrid.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                // Paraméter lista előállítása
                List<Params> pList = new List<Params>();
                Params ps;
                ps.paramName = "@pName";
                ps.paramValue = txbName.Text;
                pList.Add(ps);

                ps.paramName = "@pID";
                ps.paramValue = selectedRow["ID"].ToString();
                pList.Add(ps);


                Dbproc(connectionString, updatePerson, pList);

                #region Régi Update
                //// A kijelölt sorból kiszedem az adatokat
                //int id = Convert.ToInt32(selectedRow["ID"]);
                //string name = txbName.Text;
                //using (MySqlConnection connection = new MySqlConnection(connectionString))
                //{
                //    try
                //    {
                //        connection.Open();
                //        string query = updatePerson;
                //        MySqlCommand cmd = new MySqlCommand(query, connection);
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.Parameters.AddWithValue("@pName", name);
                //        cmd.Parameters.AddWithValue("@pID", id);

                //        cmd.ExecuteNonQuery();

                //        LoadData();
                //    }
                //    catch (Exception ex)
                //    {

                //        MessageBox.Show($"Hiba a frissítés közben: {ex.Message}");
                //    }
                //}
                #endregion Régi Update
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
                        string query = deletePerson;
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@pID", id);

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

        private void Dbproc(string con, string qu, List<Params> paramList)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                try
                {
                    connection.Open();
                    string query = qu;
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.CommandType = CommandType.StoredProcedure;


                    foreach (Params item in paramList)
                    {
                        cmd.Parameters.AddWithValue(item.paramName, item.paramValue);
                    }
                    cmd.ExecuteNonQuery();

                    LoadData();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Hiba a művelet közben:\n {ex.Message}");
                }
            }

        }
    }
}
