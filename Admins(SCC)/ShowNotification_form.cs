using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Admins_SCC_
{
    public partial class ShowNotification_form : Form
    {
        private IFirebaseClient _client;
        private int complaintCount = 0;
        String admin_role;

        public ShowNotification_form(IFirebaseClient client, String role)
        {
            InitializeComponent();
            message_tb.Visible = false;
            _client = client;
            admin_role = role;
            FetchNotifications();
        }

        private void ShowNotification_form_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // complaintCount++;
            // AddComplaintView(complaintCount);
        }

        private void AddComplaintView(int complaintId, Notification_model Record)
        {
            String id = Record.std_id.ToString();

            if(Record.std_id == "0")
            {
                id = "0000";
            }

            // Create a new Panel
            Panel complaintPanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                //Width = panelComplaints.Width - 20,
               Width = 620,
                Height = 100,
                Location = new System.Drawing.Point(10, 10 + (complaintCount - 1) * 110)
            };

            // Complaint ID Label
            Label lblComplaintID = new Label
            {

                Text = "Complaint ID: " + Record.C_ID.ToString() + "(" + id + ")",
                Location = new System.Drawing.Point(10, 10),
                Size = new Size(200, 20),
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            complaintPanel.Controls.Add(lblComplaintID);

            // Student ID Label
            /* Label lblStudentID = new Label
             {
                 Text = "Student ID: " + Record.std_id.ToString(),
                 Location = new System.Drawing.Point(10, 40)
             };
             complaintPanel.Controls.Add(lblStudentID);*/

            // Description Label
            Label lblDescription = new Label
            {
                Text = "Description: " + Record.description.ToString(),
                Location = new System.Drawing.Point(10, 40),
                Size = new Size(400, 20)
            };
            complaintPanel.Controls.Add(lblDescription);

            // Action View Label
            Label lblActionView = new Label
            {
                Text = "Action: " + Record.action.ToString(),
                Location = new System.Drawing.Point(10, 70),
                Size = new Size(300, 20)
            };
            complaintPanel.Controls.Add(lblActionView);

            // Delete Button
            Button btnDelete = new Button
            {
                Text = "Delete",
                Location = new System.Drawing.Point(complaintPanel.Width - 80, 10)
            };
            btnDelete.Click += (s, e) =>
            {
                DeleteNotification(Record.C_ID.ToString(), Record.std_id.ToString());
                panelComplaints.Controls.Remove(complaintPanel);
            };
            complaintPanel.Controls.Add(btnDelete);

            // Add the Panel to the Form's Panel
            panelComplaints.Controls.Add(complaintPanel);
        }

        private async void FetchNotifications()
        {

            if (NetworkInterface.GetIsNetworkAvailable())
            {


                FirebaseResponse response = await _client.GetAsync("Notifications");
                var notifications = JsonConvert.DeserializeObject<Dictionary<string, Notification_model>>(response.Body);

                var filteredNotifications = new List<Notification_model>();

                if (notifications != null)
                {
                    bool cond = true;
                    foreach (var notification in notifications)
                    {
                        if (notification.Value.stage == admin_role)
                        {
                            filteredNotifications.Add(notification.Value);
                            complaintCount++;
                            AddComplaintView(complaintCount, notification.Value);
                            cond = true;
                        }
                        //admin_role == "SSO" && current_role == "Main Admin"
                        if (notification.Value.stage == "Main Admin")
                        {
                            filteredNotifications.Add(notification.Value);
                            complaintCount++;
                            AddComplaintView(complaintCount, notification.Value);
                            cond = true;
                        }                   
                    }

                    if(cond == false)
                    {
                        message_tb.Visible = true;
                    }
                }
                else
                {
                    message_tb.Visible = true;
                }

            }
            else
            {
                // Show message to the user
                MessageBox.Show("You are not connected to the internet.");
            }


            //dataGridViewNotifications.DataSource = filteredNotifications;

        }

        

        /*async Task btnDelete_Click(object sender, EventArgs e, string acb)
        {
            MessageBox.Show("You have press Delete button!");
        }*/

        private async void DeleteNotification(String cId, String stdId)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                FirebaseResponse response = await _client.GetAsync("Notifications");
                var notifications = JObject.Parse(response.Body);

                var recordToDelete = notifications.Properties().FirstOrDefault(p =>
        p.Value["C_ID"].Value<string>() == cId &&
        p.Value["std_id"].Value<string>() == stdId);


                if (recordToDelete != null)
                {
                    string key = recordToDelete.Name;
                    await _client.DeleteAsync($"Notifications/{key}");
                    MessageBox.Show("Record deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Record not found.");
                }
            }
            else
            {
                // Show message to the user
                MessageBox.Show("You are not connected to the internet.");
            }
        }

        private void panelComplaints_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
