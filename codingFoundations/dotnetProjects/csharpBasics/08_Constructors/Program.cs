//* Constructors 

// new Donut(), 
// 'new' keyword, 
//  Name of Type (Donut),
//  and Parenthesis -> used to 'Construct' the object

//* 1. Access Modifier
/*
 *   In C#, 
 *   public -> Every object can 'reference'/use this obj 
 *   private -> Only the initial object can use it 
 *   protected -> Only inherited class can use it (later)
 *   internal -> Only exist w/n the 'project' (08_Constructors)
*/

//* 2. Name of the type
//* 3. Parenthesis
//* 4. the body of the code 

//* in C# we have a 'default Constructor' 
//* but, when we create 'overloads' the 
//* default constructor 'goes' away 

using _08_Classes;

Donut doug = new Donut("Jelly Filled");
System.Console.WriteLine(doug);
System.Console.WriteLine(doug.donutType);


Donut doug2 = new Donut("Oreo Donut");
System.Console.WriteLine(doug2);
System.Console.WriteLine(doug2.donutType);

Donut doug3 = new Donut();
doug3.donutType = "???";
System.Console.WriteLine((string.IsNullOrWhiteSpace(doug3.donutType)) ?
                                                    "You need to name your Donut!" :
                                                    doug3.donutType);
//todo: 1. Ex: make a class
namespace _08_Classes
{
    public class Donut
    {
        public string donutType;
        private string magicSprinkle;

        //* C# gives us this behind the scenes
        public Donut() { }

        //* create our own Constructor(s)
        //* I want the USER to 'pass-in' data of type 'string'
        //* will allow the USER to dynamically create a Donut.
        //! public Donut(){} NO LONGER EXISTS!!!!!
        //todo: we can still 'Recreate this (Donut(){}) if needed'

        //1     //2      //3
        public Donut(string type)
        {
            //4
            donutType = type;
        }

    }
}