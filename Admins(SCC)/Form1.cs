using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Admins_SCC_
{
    public partial class Form1 : Form
    {
        private string selectedRadioButtonText = " ";
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("At position no = 1");

            // Attach the CheckedChanged event handler to each radio button
            sso_radiobtn.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            registrar_radiobtn.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            vc_radiobtn.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            president_radiobtn.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }


        IFirebaseConfig Config = new FirebaseConfig
        {
            AuthSecret = "rOsipULxOQkRgKrd1iWITU57ABAeIFmo9i3oTLU5",
            BasePath = "https://student-complaint-cell-db-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient Client;

        private void Form1_Load(object sender, EventArgs e)
        {
            Client = new FireSharp.FirebaseClient(Config);
        }

        private async void RetrieveUsers()
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                FirebaseResponse response = await Client.GetAsync("Admin_Info");
                var admins = response.ResultAs<Dictionary<string, Admin_model>>();

                if (admins != null)
                {
                    int count = 0;
                    Boolean condition = false;
                    foreach (var admin in admins)
                    {
                        count++;
                        if (admin.Value.Admin_ID == email_textbox.Text)
                        {
                            condition = true;
                            if (admin.Value.Password == password_textbox.Text)
                            {
                                if (admin.Value.Name == selectedRadioButtonText)
                                {
                                    //now goto the home page,,,,
                                    //MessageBox.Show("Log in successfully!");
                                    var newform = new Form2(Client, selectedRadioButtonText);
                                    newform.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("You have selected wrong role!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Your password is incorrect!");
                            }
                        }
                        else
                        {
                            if(count == 4 && condition == false)
                            {
                                MessageBox.Show("ID is inncorrect!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No records found.");
                }
            }
            else
            {
                // Show message to the user
                MessageBox.Show("You are not connected to the internet.");
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Cast sender to a RadioButton
            RadioButton radioButton = sender as RadioButton;

            // Check if the radio button is checked
            if (radioButton != null && radioButton.Checked)
            {
                // Store the text of the checked radio button
                selectedRadioButtonText = radioButton.Text;
            }
        }

        private void logIn_btn_Click(object sender, EventArgs e)
        {
            /*var newform = new Form2(Client, selectedRadioButtonText);
            newform.Show();
            this.Hide();*/
            RetrieveUsers();
        }

    }
}
