using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Admins_SCC_
{
    public partial class Annocuncement_form : Form
    {
        private IFirebaseClient _client;
        string admin_role;
        int num_position = 10;
        int count = 0;
        public Annocuncement_form(IFirebaseClient client, string role)
        {
            InitializeComponent();
            message_tb.Visible = false;
            _client = client;
            admin_role = role;
            FetchAndDisplaySuggestions();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void AddNewSuggestionPanel(Suggestions_model record)
        {
            // Create a new panel to represent the dynamic view
            Panel newPanel = new Panel();
            newPanel.BorderStyle = BorderStyle.FixedSingle;
            newPanel.Size = new System.Drawing.Size(650, 200);
            // newPanel.Location = new System.Drawing.Point(20, 20 + scrollPanel.Controls.Count * 210);
            newPanel.Location = new System.Drawing.Point(20, 20 + count * 210);
            num_position = 210;

            // Create and add labels for student_id, suggestion_id and description
            Label studentIdLabel = new Label();
            studentIdLabel.Text = record.Student_name;
            studentIdLabel.Location = new System.Drawing.Point(10, 10);
            studentIdLabel.Font = new Font(studentIdLabel.Font.FontFamily, 10, FontStyle.Bold);
            //studentIdLabel.Size = new System.Drawing.Size(200, 30); // Set the size of the label
            newPanel.Controls.Add(studentIdLabel);

            Label suggestionIdLabel = new Label();
            suggestionIdLabel.Text = record.Suggestion_id + ": " + record.Subject;
            suggestionIdLabel.Location = new System.Drawing.Point(10, 40);
            suggestionIdLabel.Font = new Font(suggestionIdLabel.Font.FontFamily, 10, FontStyle.Bold);
            suggestionIdLabel.Size = new System.Drawing.Size(150, 30); // Set the size of the label
            newPanel.Controls.Add(suggestionIdLabel);

            Label descriptionLabel = new Label();
            descriptionLabel.Text = record.Description;
            descriptionLabel.Location = new System.Drawing.Point(10, 70);
            descriptionLabel.Size = new System.Drawing.Size(450, 100); // Set the size of the label
            newPanel.Controls.Add(descriptionLabel);

            // Create and add a delete button
            Button deleteButton = new Button();
            deleteButton.Text = "Delete";
            deleteButton.Size = new System.Drawing.Size(75, 23);
            deleteButton.Location = new System.Drawing.Point(10, 170);
            deleteButton.Click += (s, args) =>
            {
                scrollPanel.Controls.Remove(newPanel); AdjustPanelLocations();

                //essageBox.Show("Suggestion id = " + record.Suggestion_id);
                int suggestionIdToDelete = record.Suggestion_id;
                DeleteSuggestion(suggestionIdToDelete);

            };
            newPanel.Controls.Add(deleteButton);

            // Add the new panel to the scroll panel
            count++;
            scrollPanel.Controls.Add(newPanel);
        }

        private void AdjustPanelLocations()
        {
            int y = 20;
            foreach (Control control in scrollPanel.Controls)
            {
                if (control is Panel panel)
                {
                    panel.Location = new System.Drawing.Point(20, y);
                    y += 160;
                }
            }
        }

        private async void FetchAndDisplaySuggestions()
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                FirebaseResponse response = await _client.GetAsync("Suggestions_Box");
                Dictionary<string, Suggestions_model> suggestions = response.ResultAs<Dictionary<string, Suggestions_model>>();

                if (suggestions != null)
                {
                    bool cond = false;
                    foreach (var suggestion in suggestions.Values)
                    {
                        if (admin_role == "SSO")
                        {
                            if (suggestion.Student_name == "SSO")
                            {
                                AddNewSuggestionPanel(suggestion);
                                cond = true;
                            }
                        }

                        if (admin_role == "Registrar")
                        {
                            if (suggestion.Student_name == "Registrar")
                            {
                                AddNewSuggestionPanel(suggestion);
                                cond = true;
                            }
                        }

                        if (admin_role == "VC")
                        {
                            if (suggestion.Student_name == "VC")
                            {
                                AddNewSuggestionPanel(suggestion);
                                cond = true;
                            }
                        }

                        if (admin_role == "President")
                        {
                            if (suggestion.Student_name == "President")
                            {
                                AddNewSuggestionPanel(suggestion);
                                cond = true;
                            }
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
                    MessageBox.Show("No suggestions found.");
                }

            }
            else
            {
                // Show message to the user
                MessageBox.Show("You are not connected to the internet.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Define what happens when the picture box is clicked
            AddAnnouncement_form fm = new AddAnnouncement_form(_client, admin_role);
            fm.Show();
        }

        private void scrollPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void DeleteSuggestion(int Suggestion_id)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                FirebaseResponse response = await _client.DeleteAsync($"Suggestions_Box/{Suggestion_id}");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"Suggestion with ID {Suggestion_id} has been successfully deleted.");
                }
                else
                {
                    MessageBox.Show($"Failed to delete suggestion with ID {Suggestion_id}. Status code: {response.StatusCode}");
                }
            }
            else
            {
                // Show message to the user
                MessageBox.Show("You are not connected to the internet.");
            }
        }
    }
}
