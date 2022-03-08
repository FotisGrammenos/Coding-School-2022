using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionID
    {
        public Guid RequestID { get; }
        public ActionID()
        {
            RequestID = System.Guid.NewGuid();
        }
    }
}
