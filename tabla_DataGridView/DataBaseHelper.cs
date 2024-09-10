using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

public static class DatabaseHelper
{
    private static string _connectionString = "Server=ZURITA\\SQLEXPRESS;Database=Tec;Trusted_Connection=True;TrustServerCertificate=True;";

    public static void LoadUsersIntoDataGridView(ref DataGridView dgv)
    {
        // Limpia el DataGridView antes de cargar nuevos datos
        dgv.DataSource = null;

        try
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Usuarios";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dgv.DataSource = dataTable;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cargar datos: " + ex.Message);
        }
    }

    // Método para configurar la cadena de conexión si es necesario
    public static void SetConnectionString(string connectionString)
    {
        _connectionString = connectionString;
    }
}
