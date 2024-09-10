namespace tabla_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Configura la cadena de conexión si no está configurada en la clase estática
            //DatabaseHelper.SetConnectionString("Server=your_server_name;Database=your_database_name;User Id=your_user_id;Password=your_password;");

            // Cargar datos en el DataGridView al iniciar el formulario
            LoadData();
        }

        private void LoadData()
        {
            DatabaseHelper.LoadUsersIntoDataGridView(ref dgv);
        }
    }
}
