using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace FRIDv2
{
    public partial class frmHistory : Form
    {
        DataTable dt = new DataTable();
        DataTable dtr = new DataTable();
        user person = new user();
        DateTime nowday = DateTime.Now;
        public int enterCount = 0;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "4HGFTg2AavlUY70DLKbfNjsbvbtFjcSYjKfvsmXl",
            BasePath = "https://door-78c3e-default-rtdb.firebaseio.com"
        };

        IFirebaseClient client;
        public frmHistory()
        {
            InitializeComponent();
        }

        private async void cbbIDCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            dtr.Rows.Clear();
            var client = new FireSharp.FirebaseClient(config);
            FirebaseResponse res = await client.GetAsync(cbbIDCard.Text);
            user person = res.ResultAs<user>();

            // Lấy dữ liệu của nút "timein" dưới dạng FirebaseResponse
            FirebaseResponse response = await client.GetAsync(cbbIDCard.Text + "/timein");

            Dictionary<string, string> data = response.ResultAs<Dictionary<string, string>>();
            // thời gian vào
            foreach (var item in data)
            {
                dt.Rows.Add(person.name, item.Value);
            }

            dgvVao.DataSource = dt;

            FirebaseResponse conss = await client.GetAsync(cbbIDCard.Text + "/timeout");

            Dictionary<string, string> tgr = conss.ResultAs<Dictionary<string, string>>();
            // thời gian ra
            foreach (var item in tgr)
            {
                dtr.Rows.Add(person.name, item.Value);
            }
            dgvRa.DataSource = dtr;
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Time In", typeof(string));

            dtr.Columns.Add("Name", typeof(string));
            dtr.Columns.Add("Time Out", typeof(string));
        }
    }
}
