using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Detta är en dll

namespace MyMaths
{
    public class MathClass
    {

        public void PrintValues(double[] array)  //Anropar alla tre metoderna. fungerar som access till de andra metoderna
        {
            Console.WriteLine("Anrop av GetMin:" + GetMin(array));
            Console.WriteLine("Anrop av GetMax:" + GetMax(array));
            Console.WriteLine("Anrop av Average:" + Average(array));
        }


        //tre metoder: min,max och average. Vi skapar dessa metoderna.. De är skyddade för at vi skapat privata funktioner.
        private double GetMin(double[] array)  //Skall vara en vektor, därmed sätts []
        {
            double min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }
        private double GetMax(double[] array)
        {
            double max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        private double Average(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

    }
}


//Vi använder private istälelt för public