namespace Tourist_Accommodation_System
{
    public partial class Forms1 : Form
    {
        public Forms1 ()
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblClient_Click(object sender, EventArgs e)
        {
            // Criar um cliente de exemplo
            Client client = new Client(1, "João Alves", "joao@ipca.com", "911234567", "259486639", new DateTime(1990, 5, 15));

            //Exibir os dados do cliente nas Labels
            //lblClientname.Text = client.Name;
            //lblClientEmail.Text = client.Email;
            //lblClientPhone.Text = client.Phone;
            //lblClientTIN.Text = client.TIN;  // Exibe o NIF (TIN)
            //lblClientBirthDate.Text = client.BirthDate.ToShortDateString();// Exibe a data de nascimento formatada
        }

        private void lblReviews_Click(object sender, EventArgs e)
        {

        }

        private void lblAccommodation_Click(object sender, EventArgs e)
        {

        }

        private void lblReservation_Click(object sender, EventArgs e)
        {

        }

        private void lblChekcin_Click(object sender, EventArgs e)
        {

        }
    }
}
