namespace tabla_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Configura la cadena de conexi�n si no est� configurada en la clase est�tica
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
