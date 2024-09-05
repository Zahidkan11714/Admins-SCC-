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
    using FireSharp.Response;
    using System;
    using System.Drawing;
    using System.Net.NetworkInformation;
    using System.Windows.Forms;

    public partial class Suggestion_form : Form
    {
        private IFirebaseClient _client;
        int panelCount = 0;
        string admin_role = "";
        public Suggestion_form(IFirebaseClient client, string role)
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
            Panel newPanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(650, 150),
                Location = new Point(10, 10 + (170 * panelCount))
            };

            Label lblStudentId = new Label
            {
                Text = record.Student_name.ToString() + "(" + record.Student_id + "):.",
                Location = new Point(10, 10),
                Size = new Size(200, 22),
                ForeColor = Color.Black,
                Font = new Font("Arial", 10, FontStyle.Bold) // Set font to Arial, 10pt, bold
            };

            Label lblSuggestionId = new Label
            {
                Text = record.Suggestion_id + ": " + record.Subject.ToString(),
                Location = new Point(10, 30),
                Size = new Size(200, 20),
                ForeColor = Color.Black,
                Font = new Font("Arial", 10, FontStyle.Bold) // Set font to Arial, 10pt, bold
            };

            Label lblDescription = new Label
            {
                Text = record.Description.ToString(),
                Location = new Point(10, 55),
                Size = new Size(630, 145),
                ForeColor = Color.Black
            };

            newPanel.Controls.Add(lblStudentId);
            newPanel.Controls.Add(lblSuggestionId);
            newPanel.Controls.Add(lblDescription);

            scrollPanel.Controls.Add(newPanel);
            panelCount++;
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
                        if (suggestion.Target_Admin == "Yes" && admin_role == "SSO")
                        {
                            AddNewSuggestionPanel(suggestion);
                            cond = true;
                        }

                        if (suggestion.Target_Registrar == "Yes" && admin_role == "Registrar")
                        {
                            AddNewSuggestionPanel(suggestion);
                            cond = true;
                        }

                        if (suggestion.Target_VC == "Yes" && admin_role == "VC")
                        {
                            AddNewSuggestionPanel(suggestion);
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
                    MessageBox.Show("No suggestions found.");
                }
            }
            else
            {
                // Show message to the user
                MessageBox.Show("You are not connected to the internet.");
            }
        }

        private void scrollPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
