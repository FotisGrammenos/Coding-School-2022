using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Reverse
    {
        public Reverse()
        {
            
        }

        public string ReverseString(string myString)
        {
            string reversedString=String.Empty;

            for (int i = myString.Length-1; i >= 0; i--)
            {
                reversedString += myString[i];

            }

            return reversedString;
        }
    }
}
