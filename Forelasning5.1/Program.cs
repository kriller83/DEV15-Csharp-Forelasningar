using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning5._1
{
    class Program
    {
        //både ref och out pekar på den variabel som ligger utanför metodanropet
        //det yttre värdet förändras innifrån
        static void Main(string[] args) 
        {
            Program program = new Program();  //skapar en instans av klassen
            string musikText;  //måste inte ha ett värde
            string annanText;
            program.MusikByggsAvGlädje(out musikText);
            program.MusikByggsAvGlädje(out annanText);
            program.MusikByggsAvGlädje(33, out annanText, out musikText);
            Console.WriteLine(annanText + musikText);
        }
       private void MusikByggsAvGlädje(out string musikText) // behöver ej heta musikText.. //ej statisk, måste skapa en instans av klassen
        {
            musikText = "Stilla natt, heliga natt...";  //musikText får sitt värde här
        }
         void MusikByggsAvGlädje(int t, out string lyrik, out string tvau)
        {
            lyrik = t.ToString() + "PLUSS";
            tvau = lyrik + "Hej";
        }
    }
}
