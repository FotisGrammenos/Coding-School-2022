using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Person
    {
        public Guid ID { get;}
        public string Name;
        public int Age { get; set; }

        public Person()
        {
            ID= System.Guid.NewGuid();
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
