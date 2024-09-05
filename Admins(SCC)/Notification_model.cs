using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admins_SCC_
{
    internal class Notification_model
    {
        public Notification_model() { }

        public string C_ID { get; set; }
        public string std_id { get; set; }
        public string action { get; set; }
        public string stage { get; set; }
        public string description { get; set; }
    }
}
