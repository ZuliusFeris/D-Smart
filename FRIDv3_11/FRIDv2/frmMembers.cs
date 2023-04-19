using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace FRIDv2
{
    public partial class frmMembers : Form
    {
        DataTable dt = new DataTable();
        user person = new user();
        DateTime nowday = DateTime.Now;
        public int enterCount = 0;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "##############################################",
            BasePath = "##############################################"
        };
        IFirebaseClient client;

        public frmMembers()
        {
            InitializeComponent();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("status");
            dt.Columns.Add("acc");
            dt.Columns.Add("pass");
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtAcc.Enabled = false;
            txtPass.Enabled = false;
            numStatus.Enabled = false;

            btnSave.Enabled = false;

            laythongtinfirebase();
        }
        private async void laythongtinfirebase()
        {
            dt.Clear();
            client = new FireSharp.FirebaseClient(config);

            FirebaseResponse response = await client.GetAsync("/");

            string json = response.Body;
            var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

            foreach (var item in data)
            {
                FirebaseResponse laythongtin = await client.GetAsync(item.Key);
                user thongtinitem = laythongtin.ResultAs<user>();
                DataRow row = dt.NewRow();
                row["id"] = item.Key.ToString();
                row["name"] = thongtinitem.name;
                row["status"] = thongtinitem.status;
                row["acc"] = thongtinitem.account;
                row["pass"] = thongtinitem.password;

                dt.Rows.Add(row);

            }
            dgvDSMember.DataSource = "";
            dgvDSMember.DataSource = dt;

            dgvDSMember.Columns[0].HeaderText = "Id";
            dgvDSMember.Columns[1].HeaderText = "Name";
            dgvDSMember.Columns[2].HeaderText = "Status";
            dgvDSMember.Columns[3].HeaderText = "Acc";
            dgvDSMember.Columns[4].HeaderText = "Pass";
            dgvDSMember.Columns[4].Visible = false;

            btnSave.Enabled = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idver = txtID.Text;

            client = new FireSharp.FirebaseClient(config);
            user person = new user();
            person.id = txtID.Text;
            person.name = txtName.Text;
            person.password = txtPass.Text;
            person.account = txtAcc.Text;
            person.status = numStatus.Value.ToString();

            FirebaseResponse response = client.Update(idver, person);
            btnSave.Enabled = false;
            txtName.Enabled = false;
            txtAcc.Enabled = false;
            txtPass.Enabled = false;
            numStatus.Enabled = false;

            dgvDSMember.Refresh();
            laythongtinfirebase();

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            laythongtinfirebase();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCards addmember = new frmAddCards();
            addmember.ShowDialog();
        }

        private async void btnTim_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            dt.Clear();
            string luutamid = txtID.Text;
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = await client.GetAsync(luutamid);
            if (response.ResultAs<user>() != null)
            {
                user person = response.ResultAs<user>();
                DataRow row = dt.NewRow();
                row["id"] = luutamid;
                row["name"] = person.name;
                row["status"] = person.status;
                row["acc"] = person.account;
                row["pass"] = person.password;

                dt.Rows.Add(row);
                dgvDSMember.Refresh();
                dgvDSMember.DataSource = "";
                dgvDSMember.DataSource = dt;
            }
            else
            {
                txtID.ResetText();
            }
        }

        private void dgvDSMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Enabled = true;
            txtAcc.Enabled = true;
            txtPass.Enabled = true;
            numStatus.Enabled = true;
            btnSave.Enabled = true;
            if (e.RowIndex >= 0)
            {
                string id = dgvDSMember.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtID.Text = dgvDSMember.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvDSMember.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAcc.Text = dgvDSMember.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPass.Text = dgvDSMember.Rows[e.RowIndex].Cells[4].Value.ToString();
                numStatus.Value = Convert.ToInt32(dgvDSMember.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
        }

        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            Thread.Sleep(500);
            txtPass.UseSystemPasswordChar = true;
        }

    }
}
