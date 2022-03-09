using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class Multiplication : Operators
    {
        public Multiplication()
        {

        }

        public override string OperatorsToString()
        {
            return "*";
        }

        public override double ExecuteOperators(double a, double b)
        {
            return a * b;
        }
    }
}
