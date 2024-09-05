using FireSharp.Interfaces;
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

namespace Admins_SCC_
{
    public partial class ShowComplaint : Form
    {
        private IFirebaseClient _client2;
        public ShowComplaint(String std_id, String c_id, String category, String desb, String image_uri,
            String status, String stage, IFirebaseClient client)
        {
            InitializeComponent();
            _client2 = client;
            stdID_lable.Text = std_id;
            subject_lable.Text = c_id + ": " + category;
            discrib_lable.Text = desb;

            // Load image asynchronously
            LoadImageAsync(picture_boxT, image_uri);


            status_lable.Text = status;
            stage_lable.Text = stage;
        }

        private void stdID_lable_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async Task LoadImageAsync(PictureBox pictureBox, string imageUri)
        {
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.GetAsync(imageUri);
                        response.EnsureSuccessStatusCode();
                        byte[] imageBytes = await response.Content.ReadAsByteArrayAsync();

                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pictureBox.Image = Image.FromStream(ms);
                        }
                    }
                }
                else
                {
                    // Show message to the user
                    MessageBox.Show("You are not connected to the internet.");
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine($"Failed to load image from URI: {imageUri}, Error: {ex.Message}");
                // Optional: Set a placeholder image in case of error
                //pictureBox.Image = Properties.Resources.placeholder_image; // Ensure you have a placeholder image in your resources
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Home_form form = new Home_form(_client2, "");
        }

        private void ShowComplaint_Load(object sender, EventArgs e)
        {

        }
    }
}
