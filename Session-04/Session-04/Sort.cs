using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Sort
    {
        public Sort()
        {

        }
        public void SelectSort(int[] array)
        {
            int index, helper, min;
            for (int i = 0;i < array.Length; i++)
            {
                index = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[index] > array[j])
                        index = j;
                    
                }
                if (index !=i)
                {
                    helper = array[i];
                    array[i] = array[index];
                    array[index] = helper;
                }
            }
        }
    }
}
