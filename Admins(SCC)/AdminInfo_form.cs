using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Admins_SCC_
{
    public partial class AdminInfo_form : Form
    {
        private IFirebaseClient _client2;
        List<Admin_model> adminRecords;
        String current_role = "";
        public AdminInfo_form(IFirebaseClient client)
        {
            _client2 = client;
            FetchAndDisplayAdmins();
            InitializeComponent();
        }

        private void sso_btn_Click(object sender, EventArgs e)
        {
            current_role = "SSO";
            Display_Info("SSO");
        }

        private void registrar_btn_Click(object sender, EventArgs e)
        {
            current_role = "Registrar";
            Display_Info("Registrar");
        }

        private void vc_btn_Click(object sender, EventArgs e)
        {
            current_role = "VC";
            Display_Info("VC");
        }

        private void president_btn_Click(object sender, EventArgs e)
        {
            current_role = "President";
            Display_Info("President");
        }


        public async Task<List<Admin_model>> FetchAllAdminRecords()
        {
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    FirebaseResponse response = await _client2.GetAsync("Admin_Info");
                    Dictionary<string, Admin_model> admins = response.ResultAs<Dictionary<string, Admin_model>>();

                    List<Admin_model> admin_record_list = new List<Admin_model>();

                    foreach (var admin in admins.Values)
                    {
                        admin_record_list.Add(admin);
                    }

                    return admin_record_list;
                }
                else
                {
                    List<Admin_model> admin_record_list = new List<Admin_model>();
                    // Show message to the user
                    Admin_model admin_Model = new Admin_model();
                    admin_Model.Admin_ID = "000";
                    admin_Model.Name = "000";
                    admin_Model.Email = "000";
                    admin_Model.Password = "000";

                    admin_record_list.Add(admin_Model);
                    return admin_record_list;

                    MessageBox.Show("You are not connected to the internet.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching admin records: {ex.Message}");
                return null;
            }
        }

        public async void FetchAndDisplayAdmins()
        {
            adminRecords = await FetchAllAdminRecords();
        }

        public void Display_Info(String name)
        {
            if (adminRecords != null)
            {
                foreach (var admin in adminRecords)
                {
                    // Here you can display or use the admin records as needed
                    if (admin.Name == name)
                    {
                        id_text.Text = admin.Admin_ID.ToString();
                        name_text.Text = admin.Name.ToString();
                        email_text.Text = admin.Email.ToString();
                        password_text.Text = admin.Password.ToString();
                        break;
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAdminRecord();
        }

        public async Task UpdateAdminRecord()
        {

            Admin_model admin_model = new Admin_model();
            //admin_model.Admin_ID = id_text.Text;
            admin_model.Name = name_text.Text;
            admin_model.Email = email_text.Text;
            admin_model.Password = password_text.Text;

            foreach (var admin in adminRecords)
            {
                // Here you can display or use the admin records as needed
                if (admin.Name == current_role)
                {

                    admin_model.Admin_ID = admin.Admin_ID;

                    admin.Name = name_text.Text;
                    admin.Email = email_text.Text;
                    admin.Password = password_text.Text;
                }

            }

            try
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    FirebaseResponse response = await _client2.UpdateAsync($"Admin_Info/{id_text.Text}", admin_model);
                    Admin_model result = response.ResultAs<Admin_model>();
                    Console.WriteLine("Admin record updated successfully!");
                }
                else
                {
                    // Show message to the user
                    MessageBox.Show("You are not connected to the internet.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating admin record: {ex.Message}");
            }
        }

        private void Show_recordPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
