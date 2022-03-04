using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.1
            var answerOf4_1 = new Reverse();
            string name = "Fotis Grammenos";

            Console.WriteLine(answerOf4_1.ReverseString(name));

            //4.2
            Console.WriteLine("-----------------------------");
            int number;
            char userChoise;
            var answerOf4_2 = new Calculator();

            //TODO: Error hundle when the user an non-integer value
            Console.WriteLine("Give me an integer greater of zero");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now, write S/s to calculate the sum from 1 to the previous number or P/p to calculate the product");
            userChoise = Convert.ToChar(Console.ReadLine());

            if (userChoise == 'S' || userChoise == 's')
            {
                answerOf4_2.Sum(number);
            }
            else if (userChoise == 'P' || userChoise == 'p')
            {
                answerOf4_2.Product(number);
            }
            else
            {
                Console.WriteLine("Error, not right key word");
            }

            //4.3
            Console.WriteLine("-----------------------------");
            int border;
            var answerOf4_3 = new Prime();

            //TODO: Error hundle when the user an non integer value
            Console.WriteLine("Give me an integer to find the prime numbers between 1 and your number");
            border = Convert.ToInt32(Console.ReadLine());

            answerOf4_3.FindPrimes(border);

            //4_4
            Console.WriteLine("-----------------------------");
            int[] array1 = { 2, 4, 9, 12 };
            int[] array2 = { 1, 3, 7, 10 };
            var answerOf4_4 = new ArraysCalculator();

            answerOf4_4.MultiplierArray(array1, array2);

            //4_5
            Console.WriteLine("-----------------------------");
            int[] array = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
            var answerOf4_5 = new Sort();

            answerOf4_5.SelectSort(array);
            answerOf4_4.PrintArray(array);

            Console.ReadLine();
        }
    }
}
