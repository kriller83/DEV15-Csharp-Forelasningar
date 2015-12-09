using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasningar
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 3; i++)
            //{


            //Det som är på vänster sida hamnar i stacken(Boat maria), 
            //det som är på höger sida i heapen (new Boat();).

            //Boat maria = new Boat();
            //maria.SetType("Buster");
            //maria.SetNumberOfPassengers(5);
            //Console.WriteLine(
            //maria.GetNumberOfPassengers());

            //Boat lisa = new Boat();
            //lisa.SetType("Quicksilver");

            //Console.WriteLine("Write horsepowers");
            //int horsepower = int.Parse(Console.ReadLine());
            //Console.WriteLine("Write topspeed");
            //int speed = int.Parse(Console.ReadLine());

            //motorcycle boris = new motorcycle();
            //boris.SetHorsePowers(horsepower);
            //boris.SetMaxSpeed(speed);
            ////Console.WriteLine($"Boris har {boris.GetHorsePowers()} horsepowers and {boris.GetMaxSpeed()} in top speed");
            //Console.WriteLine(boris.PrintMotorcyle());

            //KAn även skrivas: boris.SetHorsePowers(int.Parse(Console.ReadLine());

            //    Console.WriteLine("How many wheels does the plane have?");
            //    airplane baronen = new airplane();
            //    baronen.SetWheels(int.Parse(Console.ReadLine()));
            //    //Console.WriteLine($"The airplane has {baronen.GetWheels()} wheels");

            //Console.WriteLine(baronen.PrintAirplane());

            Console.WriteLine("Write width");
            int myWidth = int.Parse(Console.ReadLine());
            Console.WriteLine("Write height");
            int myHeight = int.Parse(Console.ReadLine());
            Rectangle myRectangle = new Rectangle();
            myRectangle.SetWidth(myWidth);
            myRectangle.SetHeight(myHeight);

            Console.WriteLine(myRectangle.PrintRectangle());

        }
        }

    }

