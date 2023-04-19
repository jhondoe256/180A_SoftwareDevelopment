//Fields 

//A variable that is created inside a class ->   //? future reference these can be made inside of 'structs'
// its also a 'Member' of the class

//? What does it contain:
//* Access Modifier -> defines what peices of code can use it 
//* public -> everyone has access
//* private -> only containing class has access
//* protected -> only inheriting class has access
//* internal -> only the assembly has access

using _08_Classes;

Donut donut1 = new Donut();
System.Console.WriteLine(donut1);
System.Console.WriteLine("-----");

donut1.donutType = "Jelly Filled";
System.Console.WriteLine(donut1.donutType);

namespace _08_Classes
{

    public class Donut
    {
        // Publicly accessible string
        //* type    name
        public string donutType;
    }
}

