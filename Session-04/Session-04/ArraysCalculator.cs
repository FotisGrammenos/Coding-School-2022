using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ArraysCalculator
    {
        public ArraysCalculator()
        {

        }

        public void MultiplierArray(int[] array1,int[] array2)
        {
            int[] finalArray = new int[array1.Length * array2.Length];
            int indexOfFinalArray = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    finalArray[indexOfFinalArray] = array1[i] * array2[j];
                    indexOfFinalArray++;
                }
            }
            PrintArray(finalArray);
        }

        public void PrintArray(int[] array)
        {
            string index = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                index += $"{array[i]} ";
            }
            Console.WriteLine(index);
        }
    }
}
