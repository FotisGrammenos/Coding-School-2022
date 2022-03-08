using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Message
    {

        public Guid ID { get; }
        public DateTime TimeStamp { get; set; }
        public string message { get; set; } //TODO:ftia3e tin onomasia

        public Message()
        {
            ID = System.Guid.NewGuid();
            TimeStamp = DateTime.Now;
            message = String.Empty;

        }
    }
}
