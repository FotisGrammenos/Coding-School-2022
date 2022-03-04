using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Calculator
    {
        public Calculator()
        {

        }

        public void Sum(int number) 
        {
            /* just my thought*/
            /*Edw arxikopoio to finalNumber=0 gt den iparxei pote periptosi na
              parw apotelsma apo prosthesi 2 i parapanon akeraiwn pou na einai isi me to 0.
              Isos an ebaza kati san (int? finalNumber=null) gia tin arxikopoisi na itan pio swstogrameno
                + oti den eimai eksikiomenos me tin xrisi tou "int?".
              Aplso egine anafora sto mathima oti to 0 den einai i swsti arxikopoisi enos int.*/
            
            int finalNumber=0;
            for (int i = 1; i <= number; i++)
            {
                finalNumber += i;
            }

            Console.WriteLine($"the sum from 1 to {number} is : {finalNumber}");
        }

        public void Product(int number)
        {
            //edw prepei na einai arxikopoiimeno to finalNumber dioti 
            long finalNumber = 1;
            for (int i = 1; i <= number; i++)
            {
                finalNumber *= i;
            }
            if (finalNumber <= 0)
                Console.WriteLine("The final number is to big for our function, sry. Give a number less than 26 ");
            else
                Console.WriteLine($"the product from 1 to {number} is : { finalNumber}");
        }





    }
}
