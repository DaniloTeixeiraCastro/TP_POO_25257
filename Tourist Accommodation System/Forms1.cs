namespace Tourist_Accommodation_System
{
    public partial class Forms1 : Form
    {
        public Forms1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Forms1_Load(object sender, EventArgs e)
        {

        }

        private void button_client_Click(object sender, EventArgs e)
        {
          // Cria uma nova instância do formulário ClientManagementForm
          FormManagementClient clientForm = new FormManagementClient();

          // Exibe o formulário
          clientForm.Show();
        
        }
    }
}
