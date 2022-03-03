using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 Print "Hello, Fotis Grammenos"
            Console.WriteLine("Hello, Fotis Grammenos");

            //2 Print sum of numberA=2 and numberB=2 equal 4 and divison equal 1
            int sum = 2 + 2;
            int div = 2 / 2;
            Console.WriteLine("The sum of numberA and numberB is : " + sum + "The div of the numberA and numberB is : " + div);

            //3  print the result
            //3.1 
            int result = (5 * 6) - 1;
            Console.WriteLine("result 3.1 = "+ result);

            //3.2 
            result = 38 + (5 % 7);
            Console.WriteLine("result 3.2 = " + result);

            //3.3 
            result = 14 - ((3 * 6) / 7);
            Console.WriteLine("result 3.3 = " + result );
            
            //3.4
            double sqrtResult = 2+13+Math.Sqrt(7);
            Console.WriteLine("result 3.4 = " + sqrtResult );
            
            //3.5
            double arithmitis = Math.Pow(6,4)+Math.Pow(5,7);
            double paranomastis = 9 % 4;
            Console.WriteLine("result 3.5 = " + arithmitis/paranomastis);

            //4 Set values to int and string displays something. 
            int age = 23;
            string genter = "male";
            Console.WriteLine("I am " + genter + "and look like " + age);

            //5  I have 45678 sec
            int min= 45678/ 60;
            int hours=min/60;
            int days=hours/24;
            int years=days/360;
            Console.WriteLine("45678 sec is : "+ years +" Years, " +days +" Days, "+hours +" Hours, "+min+ " Minutes") ;

            //6 I have 45678 sec, now using TimeSpan 
            TimeSpan time = TimeSpan.FromSeconds(45678);
            Console.WriteLine("Using .Net Libraries: {0:dd\\.hh\\:mm\\:ss}", time);


            //7  convert from celsius degrees to Kelvin
            double celsius = 30;
            Console.WriteLine("Kelvin = {0}", celsius + 273.15);
            Console.WriteLine("Fahrenheit  = {0}", celsius* 1.8 + 32);

            Console.ReadLine();
        }
    }
}
