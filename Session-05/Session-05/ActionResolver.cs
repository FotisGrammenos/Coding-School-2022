using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal abstract class ActionResolver
    {
        public MessageLogger Logger { get; set; }
        public ActionResolver()
        {
            Logger = new MessageLogger();
        }

        public abstract ActionResponse Execute(ActionRequest actionRequest);

    }
}
