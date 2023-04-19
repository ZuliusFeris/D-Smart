using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace FRIDv2
{
    public partial class frmAddCards : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "4HGFTg2AavlUY70DLKbfNjsbvbtFjcSYjKfvsmXl",
            BasePath = "https://door-78c3e-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public frmAddCards()
        {
            InitializeComponent();
        }

        private void frmAddCards_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user us = new user();
            us.id = txtID.Text;
            us.account = txtAcc.Text;
            us.name = txtName.Text;
            us.password = txtPass.Text;
            us.status = "0";

            client = new FireSharp.FirebaseClient(config);

            Dictionary<string, string> data = new Dictionary<string, string>
            {
                { "id", us.id },
                { "name", us.name },
                { "account", us.account },
                { "password", us.password },
                { "status", us.status }
            };
            FirebaseResponse capnhat = client.Set(us.id, us);

            if (MessageBox.Show("Bạn đã lưu thành công!", "Thông báo!", MessageBoxButtons.OK) == DialogResult.OK)
                this.Close();
        }
    }
}
