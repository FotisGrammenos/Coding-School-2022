using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BaseEntitie
    {
        public Guid ID { get; set; }

        public BaseEntitie()
        {
            ID = Guid.NewGuid();
        }
    }
}
