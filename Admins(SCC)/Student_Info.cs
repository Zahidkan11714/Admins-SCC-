using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admins_SCC_
{
    public partial class Student_Info : Form
    {
        private IFirebaseClient _client;
        Student_model student_record;
        public Student_Info(IFirebaseClient client)
        {
            _client = client;
            InitializeComponent();
        }

        private async void search_pb_Click(object sender, EventArgs e)
        {
            if (search_tb.Text != "")
            {
                String student_id = search_tb.Text;
                MessageBox.Show("Call to search!");
                GetStudentRecordAsync(student_id);
            }

        }

        public async void GetStudentRecordAsync(string recordId)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                FirebaseResponse response = await _client.GetAsync("SignUpRecord/" + recordId);
                Student_model student = response.ResultAs<Student_model>();
                student_record = student;

                if (student != null)
                {
                    id_tb.Text = student.id.ToString();
                    name_tb.Text = student.name.ToString();
                    email_tb.Text = student.email.ToString();
                    password_tb.Text = student.password.ToString();
                }
                else
                {
                    id_tb.Text = null;
                    name_tb.Text = null;
                    email_tb.Text = null;
                    password_tb.Text = null;
                    MessageBox.Show("Record not founded!");
                }

            }
            else
            {
                // Show message to the user
                MessageBox.Show("You are not connected to the internet.");
            }
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            if (student_record != null)
            {
                if (name_tb.Text != "")
                {
                    if (email_tb.Text != "")
                    {
                        if (password_tb.Text != "")
                        {
                            student_record.name = name_tb.Text;
                            student_record.email = email_tb.Text;
                            student_record.password = password_tb.Text;

                            if (NetworkInterface.GetIsNetworkAvailable())
                            {
                                FirebaseResponse response = await _client.UpdateAsync($"SignUpRecord/{student_record.id.ToString()}", student_record);
                                MessageBox.Show("Student record updated successfully!");
                            }
                            else
                            {
                                // Show message to the user
                                MessageBox.Show("You are not connected to the internet.");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please fill password!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill email!");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill name!");
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            //call to delete all records related given account
            Delete_AddComplaint(student_record.id.ToString());
        }



        public async void Delete_AddComplaint(string stdId)
        {
            FirebaseResponse response = await _client.GetAsync("Add_Complaint");
            var complaints = response.ResultAs<Dictionary<string, Complaint_model2>>();

            if (complaints != null)
            {

                foreach (var complaint in complaints)
                {
                    if (complaint.Value.std_id.ToString() == stdId)
                    {
                        FirebaseResponse deleteResponse = await _client.DeleteAsync("Add_Complaint/" + complaint.Key);
                    }
                }

                Delete_HistoryComplaint(stdId);

            }
            else
            {
                Delete_HistoryComplaint(stdId);
            }
        }

        public async void Delete_HistoryComplaint(String stdId)
        {
            FirebaseResponse response = await _client.GetAsync("Complaint_History");
            var complaints = response.ResultAs<Dictionary<string, Complaint_model2>>();

            if (complaints != null)
            {

                foreach (var complaint in complaints)
                {
                    if (complaint.Value.std_id.ToString() == stdId)
                    {
                        FirebaseResponse deleteResponse = await _client.DeleteAsync("Complaint_History/" + complaint.Key);
                    }
                }
                Delete_Suggestion(stdId);
            }
            else
            {
                Delete_Suggestion(stdId);
            }
        }

        public async void Delete_Suggestion(String stdId)
        {
            FirebaseResponse response = await _client.GetAsync("Suggestions_Box");
            var complaints = response.ResultAs<Dictionary<string, Suggestions_model>>();

            if (complaints != null)
            {

                foreach (var complaint in complaints)
                {
                    if (complaint.Value.Student_id.ToString() == stdId)
                    {
                        FirebaseResponse deleteResponse = await _client.DeleteAsync("Suggestions_Box/" + complaint.Key);
                    }
                }
                Delete_Notification(stdId);
            }
            else
            {
                Delete_Notification(stdId);
            }
        }

        public async void Delete_Notification(String stdId)
        {
            FirebaseResponse response = await _client.GetAsync("Notifications");
            var complaints = response.ResultAs<Dictionary<string, Notification_model>>();

            if (complaints != null)
            {

                foreach (var complaint in complaints)
                {
                    if (complaint.Value.std_id.ToString() == stdId)
                    {
                        FirebaseResponse deleteResponse = await _client.DeleteAsync("Notifications/" + complaint.Key);
                    }
                }
                Delete_VoteComplaint(stdId);
            }
            else
            {
                Delete_VoteComplaint(stdId);
            }
        }

        public async void Delete_VoteComplaint(String stdId)
        {
            FirebaseResponse response = await _client.GetAsync("Add_vote_complaint");
            var complaints = response.ResultAs<Dictionary<string, VoteComplaint_model>>();
            List<int> List_compliants_id = new List<int>();

            if (complaints != null)
            {

                foreach (var complaint in complaints)
                {
                    if (complaint.Value.std_id.ToString() == stdId)
                    {
                        List_compliants_id.Add(complaint.Value.C_ID);
                        FirebaseResponse deleteResponse = await _client.DeleteAsync("Add_vote_complaint/" + complaint.Key);
                    }
                }

                foreach (int cmp_id in List_compliants_id)
                {
                    Delete_VotesComplaint(stdId, cmp_id);
                }

                    Delete_SignUpRecord(stdId);
            }
            else
            {
                Delete_SignUpRecord(stdId);
            }
        }

        public async void Delete_VotesComplaint(String stdId, int complaint_id)
        {
            FirebaseResponse response = await _client.GetAsync("Cast_votes");
            var complaints = response.ResultAs<Dictionary<string, Castvotes_model>>();

            if (complaints != null)
            {

                foreach (var complaint in complaints)
                {
                    if (complaint.Value.Complaint_id == complaint_id)
                    {
                        FirebaseResponse deleteResponse = await _client.DeleteAsync("Cast_votes/" + complaint.Key);
                    }
                }
            }
        }

        public async void Delete_SignUpRecord(String stdId)
        {
            FirebaseResponse response = await _client.DeleteAsync($"SignUpRecord/{stdId}");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                id_tb.Text = null;
                name_tb.Text = null;
                email_tb.Text = null;
                password_tb.Text = null;
                MessageBox.Show($"Account has been deleted successfully!");
            }
            else
            {
                MessageBox.Show($"Account failed to deleted!");
            }
        }

        private void Student_Info_Load(object sender, EventArgs e)
        {

        }
    }

}
