using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tourist_Accommodation_System.Forms;
using Tourist_Accommodation_System.Models;
using static System.Windows.Forms.DataFormats;

namespace Tourist_Accommodation_System
{
    public partial class UserControlClient : UserControl
    {
        public UserControlClient()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {

        }

        private void button_addclient_Click(object sender, EventArgs e)
        {
            FormAddEditClient addClientForm = new FormAddEditClient();
            addClientForm.ShowDialog();

        }

        private void button_editclient_Click(object sender, EventArgs e)
        { 


        }

        private void button_removeclient_Click(object sender, EventArgs e)
        {
            

        }

        private void button_listclient_Click(object sender, EventArgs e)
        {

        }
    }
}
