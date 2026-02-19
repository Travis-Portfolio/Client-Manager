using Client_Manager.Models;
using Client_Manager.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Manager
{
    public partial class CreateEditForm : Form
    {
        public CreateEditForm()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Id = 0;
            client.firstName = this.tbFirstName.Text;
            client.lastName = this.tbLastName.Text;
            client.email = this.tbEmail.Text;
            client.phoneNumber = this.tbPhone.Text;
            client.address = this.tbAddress.Text;

            var repo = new ClientRepository();
            repo.CreateClient(client);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
