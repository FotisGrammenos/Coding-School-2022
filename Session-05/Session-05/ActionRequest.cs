using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public enum ActionEnum{ 
        Convert,
        UpperCase,
        Reverse 
    }
    internal class ActionRequest : ActionID
    {
       // public Guid RequestID { get; set; }
        public string Input { get; set; }
        public ActionEnum Action { get; set; }

        public ActionRequest()
        {
            Input = String.Empty;
        }
    }
}
