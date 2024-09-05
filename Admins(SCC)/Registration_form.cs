using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admins_SCC_
{
    public partial class Registration_form : Form
    {
        private static IFirebaseClient _client;
        private int viewCount = 0;
        public Registration_form(IFirebaseClient client)
        {
            _client = client;
            FetchAllStudentRegistrationRecords();
            InitializeComponent();
            message_tb.Visible = false;
        }

        private void Registration_form_Load(object sender, EventArgs e)
        {

        }

        private void btnAddView_Click(Student_model record_model)
        {
            // Increment viewCount for positioning the next viewPanel
            viewCount++;

            // Create a new Panel to hold the view
            Panel viewPanel = new Panel();
            viewPanel.BorderStyle = BorderStyle.FixedSingle;
            //viewPanel.Width = panelContainer.Width - 20; // Adjust width as needed
            viewPanel.Width = 500;
            viewPanel.Height = 150;
            viewPanel.Top = (viewCount - 1) * 165 + 20; // Position each view vertically
            viewPanel.Left = 10;

            // Student data
            int id = record_model.id;
            string studentId = Convert.ToString(id);
            string studentName = record_model.name.ToString();
            string studentEmail = record_model.email.ToString();

            // Labels to display student data
            Label lblStudentId = new Label();
            lblStudentId.Text = $"Student ID: {studentId}";
            lblStudentId.Top = 10;
            lblStudentId.Width = 250;
            lblStudentId.Left = 10;

            Label lblStudentName = new Label();
            lblStudentName.Text = $"Student Name: {studentName}";
            lblStudentName.Top = 40;
            lblStudentName.Width = 250;
            lblStudentName.Left = 10;

            Label lblStudentEmail = new Label();
            lblStudentEmail.Text = $"Student Email: {studentEmail}";
            lblStudentEmail.Top = 70;
            lblStudentEmail.Width = 250;
            lblStudentEmail.Left = 10;

            // Accept button
            Button btnAccept = new Button();
            btnAccept.Text = "Accept";
            btnAccept.Width = 70;
            btnAccept.Top = 120;
            btnAccept.Left = 100;
            btnAccept.Click += (s, ev) =>
            {
                //MessageBox.Show($"Accepted Student ID: {studentId}");
                Register_record(record_model);
                panelContainer.Controls.Remove(viewPanel);
            };

            // Reject button
            Button btnReject = new Button();
            btnReject.Text = "Reject";
            btnReject.Width = 70;
            btnReject.Top = 120;
            btnReject.Left = 180;
            btnReject.Click += (s, ev) =>
            {
                //MessageBox.Show($"Rejected Student ID: {studentId}");
                Delete_Record(studentId);
                panelContainer.Controls.Remove(viewPanel);
            };

            // Add controls to the viewPanel
            viewPanel.Controls.Add(lblStudentId);
            viewPanel.Controls.Add(lblStudentName);
            viewPanel.Controls.Add(lblStudentEmail);
            viewPanel.Controls.Add(btnAccept);
            viewPanel.Controls.Add(btnReject);

            // Add viewPanel to the main container panel (panelContainer)
            panelContainer.Controls.Add(viewPanel);
        }

        public async Task FetchAllStudentRegistrationRecords()
        {
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    FirebaseResponse response = await _client.GetAsync("Registration_Pending");
                    Dictionary<string, Student_model> admins = response.ResultAs<Dictionary<string, Student_model>>();


                    if (admins != null)
                    {
                        foreach (var admin in admins.Values)
                        {
                            //admin_record_list.Add(admin);
                            btnAddView_Click(admin);
                        }
                    }
                    else
                    {
                        message_tb.Visible = true;
                    }
                }
                else
                {
                    List<Student_model> admin_record_list = new List<Student_model>();
                    // Show message to the user
                    Student_model student_Model = new Student_model();
                    student_Model.id = 0;
                    student_Model.name = "000";
                    student_Model.email = "000";
                    student_Model.password = "000";
                    student_Model.image_Uri = "000";

                    MessageBox.Show("You are not connected to the internet.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching admin records: {ex.Message}");
            }

        }

        private async void Register_record(Student_model record_model)
        {
            // Submit the new suggestion
            int id = record_model.id;
            string studentId = Convert.ToString(id);
            SetResponse setResponse = await _client.SetAsync($"SignUpRecord/{studentId}", record_model);

            if (setResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Student register successfully.");
                Delete_Record(studentId);
            }
            else
            {
                MessageBox.Show("Failed to register student!");
            }
        }

        private async void Delete_Record(String std_id)
        {
            FirebaseResponse response = await _client.DeleteAsync($"Registration_Pending/{std_id}");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Record deleted from Reg pending!");
            }
            else
            {
                MessageBox.Show($"Record failed to deleted from Reg pending!");
            }
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}