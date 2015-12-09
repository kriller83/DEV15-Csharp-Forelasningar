using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning5._4_Recursion
{
    class Program
    {
        //rekursiva formler
        static int startValue = 0;
        static int stopValue = 2;
        static void Main(string[] args)
        {
            //WithForLoop();

            Print(startValue);
            System.Threading.Thread.Sleep(5000);
        }

        private static void Print(int i)
        {
            Console.WriteLine(i);
            i++;
            if(i<= stopValue)
            Print(i);
            Console.WriteLine("Jag är färdig" + i);
        }
        private static void WithForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                //We want to do this with recursion
                //We know that memory is essential
                Console.WriteLine(i);
            }
            //Går det slött, kör rekursivt!!
        }
    }
}
