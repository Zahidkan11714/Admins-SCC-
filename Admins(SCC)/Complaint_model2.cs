using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admins_SCC_
{
    internal class Complaint_model2
    { 
        public int C_ID { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public string image_Uri { get; set; }
        public string stage { get; set; }
        public string status { get; set; }
        public int std_id { get; set; }

        public int show_id { get; set; }

        //long created_at, updated_at, escalation_time;
        public long created_at { get; set; }
        public long updated_at { get; set; }
        public long escalation_time { get; set; }



        // Parameterless constructor for deserialization
        public Complaint_model2() { }

        // Constructor with parameters
        public Complaint_model2(int c_ID, string Category, string description, string imageUri, string stage, string status, int std_ID)
        {
            C_ID = c_ID;
            category = Category;
            description = description;
            image_Uri = imageUri;
            stage = stage;
            status = status;
            std_id = std_ID;
        }
    }



}
