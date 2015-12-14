using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning14_Enum
{
    enum Menu   //egen fil
    {
        Add =1, Substract, Multiply, Devide, End, DevineSugar   //Här kan man lägga till, och automatiskt läggs det till i listan.
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenuWithEnums();  //extraherat metoden och lagt till i main

            bool loopa = true;  //Forstätter menyn så länge den är true
            do
            {
                //Console.Clear();
                //Console.ForegroundColor = ConsoleColor.White;
                int tal;
                if (int.TryParse(Console.ReadLine(), out tal))
                {
                    Menu menu = (Menu) tal;
                    switch (menu) //Ställ dig på switch och tryck på lampan..! 
                    {
                        case Menu.Add:
                            Console.WriteLine(Menu.Add);
                            break;
                        case Menu.Substract:
                            Console.WriteLine(Menu.Substract);
                            break;
                        case Menu.Multiply:
                            Console.WriteLine(Menu.Multiply);
                            break;
                        case Menu.Devide:
                            Console.WriteLine(Menu.Devide);
                            break;
                        case Menu.End:
                            Console.WriteLine(Menu.End);
                            break;
                        case Menu.DevineSugar:
                            Console.WriteLine(Menu.DevineSugar);
                            loopa = false;
                            break;
                        default:
                            //throw new ArgumentOutOfRangeException();
                            Console.WriteLine("Something went wrong, please try again");
                            break;
                    }
                   // System.Threading.Thread.Sleep(5000);
                }


                //Läs in ett tal
                //Omvandla talet till enum
                //switcha på enumet
                //Vi får nog loopa detta.. hmm.. 
            } while (loopa);

            Console.ReadLine();
        }

        private static void PrintMenuWithEnums()
        {
            int counter = 1; //räknar ut vilken position
            foreach (var hejhej in Enum.GetNames(typeof (Menu)))
            {
                Console.WriteLine("{0}: {1}", counter++, hejhej); //{0} = counter++ och {1} = variabeln hejhej
            }
            Console.WriteLine("Please enter a number from the list above");
        }
    }
}

/*Enum = Tal-litteraler som är konstanter
 * Kollektion av konstanter
 * Enum har automatiskt ToString i samma namn som man anger
 * Syntax:

 enum identifierare { 
    konstant 1,      //får 0 automatiskt
    konstant 2,
    --
    --
    konstant N
}

    //Kan skapa en egen klass för enum, men går bra att skriva i program. 

    */
