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
using FireSharp.Config;
using System.Net.NetworkInformation;

namespace Admins_SCC_
{
    public partial class Votecomplaint_form : Form
    {
        public IFirebaseClient _client3;
        private int panelCount = 0;
        string admin_role = "";
        public Votecomplaint_form(IFirebaseClient client, String role)
        {
            InitializeComponent();
            message_tb.Visible = false;
            _client3 = client;
            admin_role = role;
            RetrieveComplaints();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        public void AddNewComplaintPanel(VoteComplaint_model complaint)
        {
            Panel newPanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(740, 280),
                Location = new Point(10, 10 + (290 * panelCount))
            };

            Label lblStudentID = new Label
            {
                Text = "Student ID: " + complaint.std_id.ToString(),
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(10, 10),
                Size = new Size(200, 20)
            };

            Label lblComplaintID = new Label
            {
                Text = "Complaint ID: " + complaint.C_ID,
                Location = new Point(10, 40),
                Size = new Size(300, 20)
            };

            Label lblSubject = new Label
            {
                Text = "Subject: " + complaint.category,
                Location = new Point(10, 70),
                Size = new Size(300, 20)
            };

            Label lblQuestion = new Label
            {
                Text = complaint.Question.ToString(),
                Location = new Point(10, 100),
                Size = new Size(300, 20)
            };

            // Create a custom progress bar for Agree
            CustomProgressBar progressBarAgree = new CustomProgressBar
            {
                Text = complaint.Option_1,
                Location = new Point(10, 130),
                Size = new Size(300, 30),
                Percentage = complaint.Option1_Count // Example initial percentage
            };

            // Create a custom progress bar for Not Agree
            CustomProgressBar progressBarNotAgree = new CustomProgressBar
            {
                Text = complaint.Option_2,
                Location = new Point(10, 170),
                Size = new Size(300, 30),
                Percentage = complaint.Option2_Count // Example initial percentage
            };

            Label lblStatus = new Label
            {
                //Text = "Status: " + complaint.Status,
                Text = "Status: " + "Pending",
                Location = new Point(10, 210),
                Size = new Size(150, 20)
            };

            Label lblStage = new Label
            {
                Text = "Stage: " + complaint.stage,
                Location = new Point(10, 230),
                Size = new Size(150, 20)
            };

            Button btnSolve = new Button
            {
                Text = "Solve",
                Location = new Point(320, 240),
                Size = new Size(100, 30)
            };
            // btnSolve.Click += (s, e) => MessageBox.Show("Complaint marked as solved!");
            btnSolve.Click += async (sender, e) => await btnSolve_Click(sender, e, complaint);

            async Task btnSolve_Click(object sender, EventArgs e, VoteComplaint_model complaint)
            {
                var result = MessageBox.Show("Are you sure the problem has been solved?", "Confirm Solve", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Update the complaint status in the Add_Complaint table
                    complaint.status = "Solved";

                    if (NetworkInterface.GetIsNetworkAvailable())
                    {

                        FirebaseResponse updateResponse = await _client3.UpdateAsync($"Add_vote_complaint/{complaint.C_ID}", complaint);

                        if (updateResponse.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show("Complaint status updated to solved.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the complaint status.");
                        }
                    }
                    else
                    {
                        // Show message to the user
                        MessageBox.Show("You are not connected to the internet.");
                    }
                }
            }

            newPanel.Controls.Add(lblStudentID);
            newPanel.Controls.Add(lblComplaintID);
            newPanel.Controls.Add(lblSubject);
            newPanel.Controls.Add(lblQuestion);
            newPanel.Controls.Add(progressBarAgree);
            newPanel.Controls.Add(progressBarNotAgree);
            newPanel.Controls.Add(lblStatus);
            newPanel.Controls.Add(lblStage);
            newPanel.Controls.Add(btnSolve);

            //this.Controls.Add(newPanel);
            //this.Controls.Add(scrollablePanel);
            scrollablePanel.Controls.Add(newPanel);
            panelCount++;
        }


        private async void RetrieveComplaints()
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                FirebaseResponse response = await _client3.GetAsync("Add_vote_complaint");

                Dictionary<string, VoteComplaint_model> complaints = response.ResultAs<Dictionary<string, VoteComplaint_model>>();

                List<VoteComplaint_model> complaintList = new List<VoteComplaint_model>();

                if (complaints != null)
                {
                    bool cond = false;
                    foreach (var complaint in complaints)
                    {
                        if (complaint.Value != null)
                        {
                            string current_role = complaint.Value.stage.ToString();

                            if (current_role == admin_role)
                            {
                                AddNewComplaintPanel(complaint.Value);
                                cond = true;
                            }

                            if (admin_role == "SSO" && current_role == "Main Admin")
                            {
                                AddNewComplaintPanel(complaint.Value);
                                cond = true;
                            }

                            complaintList.Add(complaint.Value);
                        }
                        else
                        {
                            MessageBox.Show($"Complaint with key {complaint.Key} is null.");
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
                    MessageBox.Show("No complaints found.");
                }
            }
            else
            {
                // Show message to the user
                MessageBox.Show("You are not connected to the internet.");
            }
        }

        private void scrollablePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class VoteComplaint_model
    {
        public int std_id { get; set; }
        public int C_ID { get; set; }
        public string category { get; set; }
        public string Question { get; set; }
        public String Option_1 { get; set; }
        public String Option_2 { get; set; }
        public int Option1_Count { get; set; }
        public int Option2_Count { get; set; }
        public string status { get; set; }
        public string stage { get; set; }
    }


    public class CustomProgressBar : Control
    {
        public string Text { get; set; }
        public int Percentage { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Draw the filled part of the progress bar
            g.FillRectangle(Brushes.Teal, 0, 0, (int)(this.Width * (Percentage / 100.0)), this.Height);

            // Draw the border of the progress bar
            g.DrawRectangle(Pens.Black, 0, 0, this.Width - 1, this.Height - 1);

            // Draw the text
            SizeF textSize = g.MeasureString($"{Text} {Percentage}%", this.Font);
            PointF textPosition = new PointF((this.Width - textSize.Width) / 2, (this.Height - textSize.Height) / 2);
            g.DrawString($"{Text} {Percentage}%", this.Font, Brushes.Black, textPosition); // Set the text color to black
        }

    }

}
