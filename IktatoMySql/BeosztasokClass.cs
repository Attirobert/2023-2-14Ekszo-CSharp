using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IktatoMySql
{
    class BeosztasokClass
    {
        public MySqlConnection connection;

        public BeosztasokClass()
        {
        }

        public void dataInsert(DataRow row, MySqlConnection connection)
        {
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO beosztasok (Beosztas) VALUES (@param2)", connection))
            {
                cmd.Parameters.Add("@param2", MySqlDbType.VarChar, 20).Value = row["Beosztas"];

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void dataUpdate(DataRow row, MySqlConnection connection)
        {
            using (MySqlCommand cmd = new MySqlCommand("UPDATE beosztasok SET Beosztas = @Param2 WHERE Id_Beosztas = @PrimaryKey", connection))
            {
                cmd.Parameters.Add("@param2", MySqlDbType.VarChar, 20).Value = row["Beosztas"];

                cmd.Parameters.Add("@PrimaryKey", MySqlDbType.Int32, 11).Value = row["Id_Beosztas", DataRowVersion.Original];

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void dataDelete(DataRow row, MySqlConnection connection)
        {
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM beosztasok WHERE Id_Beosztas = @PrimaryKey", connection))
            {
                cmd.Parameters.Add("@PrimaryKey", MySqlDbType.Int32, 11).Value = row["Id_Beosztas", DataRowVersion.Original];

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
