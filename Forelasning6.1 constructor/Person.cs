using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning6._1_constructor
{
    class Person
    {
        int age;
        string lastName;
        public Person()
        {
            age = 0;
            this.lastName = lastName;
        }
        public Person(int age, string lastName)  //Överlagrad constructor
        {
            this.age = age;
            this.lastName = lastName;
        }



        /*
        - En constructor används för att skapa/konstruera ett object.
        - Ser ut som en metod fast har samma namn som klassen vi skapar.
        - Defaultconstructor som inte har några inparametrar.
        - Constructorn körs alltid när new anropas på berörd klass
        - Man kan skapa överlagrade konstruktorer med inparametrar i
        - Constructorn bygger upp objektet/klassen
        - inget returvärde!
        */
    }
}
