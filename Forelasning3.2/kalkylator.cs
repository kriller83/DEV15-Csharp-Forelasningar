using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning3._2
{
    public class kalkylator
    {
        public /*public är returvärdet*/ void PrintMinMaxAverage(int[] array)
        {
            int min = array[0];
            int max = array[0];
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                    min = array[i];
                if (max < array[i])
                    max = array[i];
                sum = sum + array[i];
            }
            Console.WriteLine("Min är:" + min);
            Console.WriteLine("Max är:" + max);
            Console.WriteLine("Average är:" + sum/array.Length);
        }
    }
}