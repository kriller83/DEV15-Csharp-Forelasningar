using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7
{
    class Va
    {
        string questionMark;  //Backing-field
        double inflection;  //Backing-field  Mellan 3.0 och 17.0
    
    public string QuestionMark  //Property för QuestionMark
    {
        get { return questionMark; }
        set
        {

                //Ursprunglig kod

                /*if (value != null && 
                value[0].ToString().ToUpper() == value[0].ToString() &&
                value[value.Length - 1] == '?') */

                //Ska kunna läsa det som en mening, därför faktoriserar vi. 
                var firstCharIsUpperCase = value[0].ToString().ToUpper() == value[0].ToString();
                var endsWithQuestionMark = value[value.Length - 1] == '?';
                var enterValidValue = value != null && firstCharIsUpperCase && endsWithQuestionMark;
                if (enterValidValue)
                {
                    questionMark = value;
                }
                else
                    throw new Exception("QuestionMark got an invalid value!");
            }
    }
    public double Inflection //Property för Inflection
        {
            get{ return inflection; }
            set
            {
                //if(value >= 3 && value <= 20)
                var validValue = value >= 3.0 && value <= 17.0;  //använd quickaction(ctrl + "+" + ".") och ändra för att underlätta
                if (validValue)
                    inflection = value;
                else
                    throw new Exception("Wrong value!");
            }
        }
    public Va()  //Konstruktor 1
    {
        QuestionMark = "Hej?";
        Inflection = 5.6;
    }
    public Va(string questionMark) //Konstruktor 2 (med en inparameter) en överlagring av konstruktor 1
    {
        QuestionMark = questionMark;
        Inflection = 3.5;
    }
    public Va(string questionMark, double inflection)  //Konstruktor 3 (med två inparametrar) Ytterliagre en överlagring
    {
        QuestionMark = questionMark;
        Inflection = inflection;
    }
    public override string ToString()  //ToString som skriver ut
    {
        return $"Questionmark: {QuestionMark} Inflection: {Inflection}";
    }
    }
}

//Skapa stor bokstav på första ordet, kontrollera om ? avslutar
//Skapa propertys som valideras
//Skapa 3 konstruktorer
//Skapa tostring
//skapa 3 instanser och skriv ut dem