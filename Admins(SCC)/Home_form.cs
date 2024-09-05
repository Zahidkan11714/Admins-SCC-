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
using FireSharp.Interfaces;
using FireSharp.Response;
using Tensorflow;  // Correct namespace for TensorFlow.NET
using Tensorflow.NumPy;
using static Tensorflow.Binding;

namespace Admins_SCC_
{
    public partial class Home_form : Form
    {
        private IFirebaseClient _client2;
        private Graph graph;
        private Session session;
        private int panelCount = 0;
        string admin_role = "";
        String name_nodes;
        private ProgressBar progressBar;
        private List<Complaint_model2> _complaintsList = new List<Complaint_model2>();
        string inputNode = null;
        string outputNode = null;

        public Home_form(IFirebaseClient client, string role)
        {
            InitializeComponent();
            message_tb.Visible = false;
            _client2 = client;
            admin_role = role;
            //LoadModel();
            AddRecords();
        }

        private void LoadModel()
        {
            graph = new Graph();
            var model = File.ReadAllBytes("C:\\Users\\muham\\OneDrive\\Desktop\\NLP2\\model.h5");
            graph.Import(model);
            // Access input and output layers
            var operations = graph.ReturnOperations;
            // Find the input node (usually has no inputs)
            session = new Session(graph);
        }

        private bool IsComplaintRelevant(string complaintDescription)
        {
            // Convert input description to tensor
            var inputTensor = np.array(new[] { complaintDescription });

            // Retrieve input and output operations from the graph
            var inputOperation = graph.OperationByName("embedding_1"); // Use the actual input node name
            var outputOperation = graph.OperationByName("dense_1"); // Use the actual output node name

            // Run the model
            var output = session.run(new[] { outputOperation }, new FeedItem(inputOperation, inputTensor));

            // Convert the output tensor to a float array
            var result = output[0].ToArray<float>();

            // Assuming binary classification (relevant or not relevant)
            return result[0] >= 0.5f;
        }



        public void AddRecords()
        {
            RetrieveComplaints();
        }

        private void AddNewPanel(Complaint_model2 complaint)
        {
            String c_id = complaint.C_ID.ToString();
            String sub = complaint.category.ToString();
            String discb = complaint.description.ToString();

            Panel newPanel = new Panel();
            newPanel.BorderStyle = BorderStyle.FixedSingle;
            newPanel.Size = new Size(740, 100);
            newPanel.Location = new Point(10, 60 + (110 * panelCount));

            Label lblName = new Label();
            lblName.Text = c_id + ": " + sub;
            lblName.Font = new Font("Arial", 10, FontStyle.Bold);
            lblName.Location = new Point(10, 10);
            lblName.Size = new Size(200, 20);

            Label lblDescription = new Label();
            lblDescription.Text = discb;
            lblDescription.Location = new Point(10, 30);
            lblDescription.Size = new Size(600, 20);

            Button btnForward = new Button();
            btnForward.Text = "Forward";
            btnForward.Location = new Point(120, 60);
            btnForward.Size = new Size(100, 30);
            btnForward.Click += async (sender, e) => await btnForward_Click(sender, e, complaint);
            //btnForward.Click += new EventHandler(btnForward_Click, complaint);

            Button btnProcess = new Button();
            btnProcess.Text = "Process";
            btnProcess.Location = new Point(230, 60);
            btnProcess.Size = new Size(100, 30);
            btnProcess.Click += async (sender, e) => await btnProcess_Click(sender, e, complaint);
            if (complaint.status == "Processing")
            {
                btnProcess.BackColor = Color.Yellow;  // Change this color as needed
            }

            Button btnSolve = new Button();
            btnSolve.Text = "Solve";
            btnSolve.Location = new Point(340, 60);
            btnSolve.Size = new Size(100, 30);
            btnSolve.Click += async (sender, e) => await btnSolve_Click(sender, e, complaint);

            Button btnOpen = new Button();
            btnOpen.Text = "Open";
            btnOpen.Location = new Point(450, 60);
            btnOpen.Size = new Size(100, 30);
            btnOpen.Click += new EventHandler(btnOpen_Click); // Attach the event handler

            if (admin_role == "VC" || admin_role == "President")
            {
                btnForward.Visible = false;
            }

            newPanel.Controls.Add(lblName);
            newPanel.Controls.Add(lblDescription);
            newPanel.Controls.Add(btnForward);
            newPanel.Controls.Add(btnProcess);
            newPanel.Controls.Add(btnSolve);
            newPanel.Controls.Add(btnOpen);

            panelScrollable.Controls.Add(newPanel);
            panelCount++;


            void btnAdminInfo_Click(object sender, EventArgs e)
            {
                MessageBox.Show("You Press AdminInfo button!");
            }

            async Task btnForward_Click(object sender, EventArgs e, Complaint_model2 complaint)
            {
                MessageBox.Show("You Press forward button!");

                string next_admin = "";

                if (admin_role == "SSO")
                {
                    next_admin = "Registrar";
                }

                if (admin_role == "Registrar")
                {
                    next_admin = "VC";
                }

                var updateData = new Dictionary<string, object>
                {
                    { "stage", next_admin }
                };

                FirebaseResponse response = await _client2.UpdateAsync($"Add_Complaint/{complaint.C_ID}", updateData);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Complaint forwarded to Registrar.");
                }
                else
                {
                    MessageBox.Show("Failed to forward the complaint.");
                }
            }

            async Task btnProcess_Click(object sender, EventArgs e, Complaint_model2 complaint)
            {
                MessageBox.Show("You Press process button!");

                if (complaint.status.ToString() == "Processing")
                {
                    MessageBox.Show("Complaint status is already processing!");
                }
                else
                {
                    var updateData = new Dictionary<string, object>
                    {
                        { "status", "Processing" }
                    };

                    btnProcess.BackColor = Color.Yellow;  // Change this color as needed

                    FirebaseResponse response = await _client2.UpdateAsync($"Add_Complaint/{complaint.C_ID}", updateData);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Complaint status change to process.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to change the status of complaint.");
                    }
                }
            }

            async Task btnSolve_Click(object sender, EventArgs e, Complaint_model2 complaint)
            {
                var result = MessageBox.Show("Are you sure the problem has been solved?", "Confirm Solve", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Update the complaint status in the Add_Complaint table
                    complaint.status = "Solved";

                    FirebaseResponse updateResponse = await _client2.UpdateAsync($"Add_Complaint/{complaint.C_ID}", complaint);

                    if (updateResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Complaint status updated to solved.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the complaint status.");
                    }
                }
            }


            void btnOpen_Click(object sender, EventArgs e)
            {
                ShowComplaint showcomplaint = new ShowComplaint(complaint.show_id.ToString(), c_id, sub,
                discb, complaint.image_Uri.ToString(), complaint.status.ToString(), complaint.stage.ToString(), _client2);
                showcomplaint.Show();
            }
        }

        private async void RetrieveComplaints()
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                FirebaseResponse response = await _client2.GetAsync("Add_Complaint");
                Dictionary<string, Complaint_model2> complaints = response.ResultAs<Dictionary<string, Complaint_model2>>();
                int complaintCount = complaints.Count;

                if (complaints != null)
                {
                    bool cond = false;
                    foreach (var complaint in complaints)
                    {
                        if (!IsComplaintRelevant(complaint.Value.description))
                        {
                            MessageBox.Show("Complaint is irrelevant!");
                        }
                        else
                        {
                            MessageBox.Show("Complaint is relevant!");
                        }
                        

                        string current_role = complaint.Value.stage.ToString();

                        if (current_role == admin_role)
                        {
                            AddNewPanel(complaint.Value);
                            cond = true;
                        }

                        if (admin_role == "SSO" && current_role == "Main Admin")
                        {
                            AddNewPanel(complaint.Value);
                            cond = true;
                        }
                        _complaintsList.Add(complaint.Value);

                    }

                    if(cond == false)
                    {
                        message_tb.Visible = true;
                    }
                    //MessageBox.Show("Admin role is " + admin_role);
                }
                else
                {
                    MessageBox.Show("No complaints found.");
                }
            }
            else
            {
                // Show message to the user
                MessageBox.Show("You are not connected to the internet.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            String search_id = search_box.Text;

            if (search_box.Text != "")
            {
                int searchId = int.Parse(search_box.Text);
                ShowComplaintById(searchId);
            }
        }

        private void ShowComplaintById(int complaintId)
        {
            var complaint = _complaintsList.FirstOrDefault(c => c.C_ID == complaintId);

            if (complaint != null)
            {
                // Optionally, you can clear the panelScrollable and only show the selected complaint
                panelScrollable.Controls.Clear();
                panelScrollable.Controls.Add(search_pannel);
                panelCount = 0;
                AddNewPanel(complaint);
            }
            else
            {
                MessageBox.Show($"Complaint with ID {complaintId} not found.");
            }
        }


        private void panelScrollable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
