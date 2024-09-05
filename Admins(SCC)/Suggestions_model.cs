using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admins_SCC_
{
    internal class Suggestions_model
    {
        public Suggestions_model() { }

        public Suggestions_model(int sug_id, int std_id, string std_name, string sub, string desb,
            string T_admin, string T_std, string T_registrar, string T_vc)
        {
            Suggestion_id = sug_id;
            Student_id = std_id;
            Student_name = std_name;
            Subject = sub;
            Description = desb;
            Target_Admin = T_admin;
            Target_Stduent = T_std;
            Target_Registrar = T_registrar;
            Target_VC = T_vc;

        }

        public int Suggestion_id { get; set; }
        public int Student_id { get; set; }
        public string Student_name { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Target_Admin { get; set; }
        public string Target_Stduent { get; set; }
        public string Target_Registrar { get; set; }
        public string Target_VC { get; set; }
    }
}
