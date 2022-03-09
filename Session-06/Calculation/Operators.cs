using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public abstract class Operators
    {
        public Operators()
        {

        }

        public abstract double ExecuteOperators(double a, double b);

        public abstract string OperatorsToString();

    }
}
