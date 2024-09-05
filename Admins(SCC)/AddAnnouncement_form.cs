using Admins_SCC_;
using FireSharp.Interfaces;
using FireSharp.Response;


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
using System.Net.NetworkInformation;

namespace Admins_SCC_
{
    public partial class AddAnnouncement_form : Form
    {
        private IFirebaseClient _client;
        string admin_role = "";
        public AddAnnouncement_form(IFirebaseClient client, string role)
        {
            InitializeComponent();
            _client = client;
            admin_role = role;

        }

        private void Annocuncement_form_Load(object sender, EventArgs e)
        {

        }

        private async void FetchAndSubmitSuggestion()
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                // Fetch the last suggestion ID
                FirebaseResponse response = await _client.GetAsync("Last_Complaint_id/Last_suggestion_id");
                int lastSuggestionId = response.ResultAs<int>();

                // Prepare new suggestion data
                int newSuggestionId = lastSuggestionId + 1;
                string subjectText = subject_text.Text;
                string descriptionText = discribtion_text.Text;

                string admin_name = "";
                if (admin_role == "SSO")
                {
                    admin_name = "SSO";
                }

                if (admin_role == "Registrar")
                {
                    admin_name = "Registrar";
                }

                if (admin_role == "VC")
                {
                    admin_name = "VC";
                }

                if (admin_role == "President")
                {
                    admin_name = "President";
                }



                Suggestions_model newSuggestion = new Suggestions_model
                {
                    Suggestion_id = newSuggestionId,
                    Student_id = 0000,
                    Student_name = admin_name,
                    Subject = subjectText,
                    Description = descriptionText,
                    Target_Admin = "Yes",
                    Target_Stduent = "Yes",
                    Target_Registrar = "No",
                    Target_VC = "No"
                };

                // Submit the new suggestion

                SetResponse setResponse = await _client.SetAsync($"Suggestions_Box/{newSuggestionId}", newSuggestion);

                if (setResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Suggestion submitted successfully.");
                    // Update the last suggestion ID in the Last_Complaint_id table
                    await _client.SetAsync("Last_Complaint_id/Last_suggestion_id", newSuggestionId);
                    subject_text.Text = "";
                    discribtion_text.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to submit suggestion.");
                }
            }
            else
            {
                // Show message to the user
                MessageBox.Show("You are not connected to the internet.");
            }


        }

        private void AddAnnouncement_form_Load(object sender, EventArgs e)
        {

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (subject_text.Text == "" && discribtion_text.Text == "")
            {
                MessageBox.Show("Null suggestion is not acceptable!");
            }
            else
            {
                FetchAndSubmitSuggestion();
            }
        }
    }
}
