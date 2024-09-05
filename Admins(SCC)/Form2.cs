using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class Form2 : Form
    {
        private IFirebaseClient _client = null;
        string role_admin = "";
        public Form2(IFirebaseClient client, string role)
        {
            InitializeComponent();
            _client = client;
            role_admin = role;
            adminName_text.Text = role;

            if (role_admin == "SSO" || role_admin == "VC" || role_admin == "President")
            {
                AdminInfo_btn.Visible = false;
                studentInfo_btn.Visible = false;
                registration_btn.Visible = false;
            }


            loadform(new Home_form(_client, role_admin));
        }

        public void loadform(object Form)
        {
            if (this.main_panel.Controls.Count > 0)
                this.main_panel.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(f);
            this.main_panel.Tag = f;
            f.Show();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            loadform(new Home_form(_client, role_admin));
        }

        private void notify_btn_Click(object sender, EventArgs e)
        {
            loadform(new notify_form(_client, role_admin));
        }

        private void AdminInfo_btn_Click(object sender, EventArgs e)
        {
            loadform(new AdminInfo_form(_client));
        }

        private void annocuncement_btn_Click(object sender, EventArgs e)
        {
            loadform(new Annocuncement_form(_client, role_admin));
        }

        private void voteComplaint_btn_Click(object sender, EventArgs e)
        {
            loadform(new Votecomplaint_form(_client, role_admin));
        }
        private void studentInfo_btn_Click(object sender, EventArgs e)
        {
            loadform(new Student_Info(_client));
        }

        private void registration_btn_Click(object sender, EventArgs e)
        {
            loadform(new Registration_form(_client));
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form nextForm = new Form1(); // Replace NextForm with your next form class

            // Show the next form
            nextForm.Show();

            // Close all previous forms
            this.Hide();
        }
    }
}
