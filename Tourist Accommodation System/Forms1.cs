using Tourist_Accommodation_System.Forms;

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
            FormManagementClient client = new FormManagementClient();
            client.Show();
        }

        private void button_accommodation_Click(object sender, EventArgs e)
        {
            FormManagementAccommodation accomodationForm = new FormManagementAccommodation();
            accomodationForm.Show();

        }

        private void button_reservation_Click(object sender, EventArgs e)
        {
            FormManagementReservation reservation = new FormManagementReservation();
            reservation.Show();

        }

        private void button_reviews_Click(object sender, EventArgs e)
        {
            FormManagementReviews reviews = new FormManagementReviews();
            reviews.Show();

        }

        private void button_checkin_Click(object sender, EventArgs e)
        {
            FormManagementCheckin checkin = new FormManagementCheckin();
            checkin.Show();
        }


    }
}
