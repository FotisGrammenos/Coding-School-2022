using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instidute
{
    [Serializable]
    public class Person
    {
        public Guid ID { get; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            ID = System.Guid.NewGuid();
            Name = string.Empty;
            Age = 0;
        }
    }
}
