using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Prime
    {
        public Prime()
        {

        }

        public void FindPrimes(int number)
        {
            bool isPrime=true;
            string Allprimes=string.Empty;
            for (int i = 1; i <= number; i++)
            {
                isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    int test = i % j;
                    if (test == 0)
                    {
                        isPrime = false;
                        //den to di3ame sto mathima alla to break einai meros (kata kapoion tropo) ton Iterations 
                        break;
                    }
                }
                if(isPrime)
                    Allprimes += $"{i} ";
            }
            Console.WriteLine($"The prime numbers between 1 and {number} is : {Allprimes}");
        }
    }
}
