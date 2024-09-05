using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admins_SCC_
{
    public partial class notify_form : Form
    {
        private IFirebaseClient _client;
        string admin_role = "";
        public notify_form(IFirebaseClient client, string role)
        {
            InitializeComponent();
            _client = client;
            admin_role = role;

            if(admin_role == "President")
            {
                suggestion_btn.Visible = false;
            }

            loadform(new ShowNotification_form(_client, admin_role));
        }

        private void Notify_btn_Click(object sender, EventArgs e)
        {
            loadform(new ShowNotification_form(_client, admin_role));
        }

        public void loadform(object Form)
        {
            if (this.Notify_pannel.Controls.Count > 0)
                this.Notify_pannel.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Notify_pannel.Controls.Add(f);
            this.Notify_pannel.Tag = f;
            f.Show();
        }

        private void suggestion_btn_Click(object sender, EventArgs e)
        {
            loadform(new Suggestion_form(_client, admin_role));
        }

        private void Notify_pannel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
