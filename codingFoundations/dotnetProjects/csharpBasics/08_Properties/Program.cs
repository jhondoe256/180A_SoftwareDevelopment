//* Properties -> variables that are on an object that have the ability to tell the compiler if users
//* can read/write to it.

//* What makes properties different than fields:
//* allows the variable to : 
//* read , write, or compute

//* Allows us an easier approach to have safety w/n our application

Donut doug = new Donut("Sprinkles");

//read data
System.Console.WriteLine(doug.Filling);

//write to data
doug.Filling = "oreo filling";

//read our changes
System.Console.WriteLine(doug.Filling);

//* Use the "GetMethod"
Console.WriteLine($"using GetMethod: {doug.GetDonutType()}");
doug.SetDonutType("Updated Sprinkles");
Console.WriteLine($"using GetMethod: {doug.GetDonutType()}");


Donut fullDonut = new Donut("My Type", "hated sprinkles", "Glazed", .50m, true);
System.Console.WriteLine(fullDonut);

System.Console.WriteLine($"{fullDonut.GetDonutType()} - {fullDonut.Topping} - {fullDonut.Price} - {fullDonut.IsSpecial}");

public class Donut
{
    //private backing field -> old school way....
    private string _donutType;
    private string _filling;  // defaults to null 

    public Donut(string donutType)
    {
        _donutType = donutType;
        _filling = "basic filling";
    }

    public Donut(string donutType, string filling, string topping, decimal price, bool IsSpecial)
    {
        _donutType = donutType;
        Filling = filling;
        Topping = topping;
        Price = price;
        this.IsSpecial = IsSpecial;
    }

    public Donut(string donutType, string filling)
    {
        _donutType = donutType;
        Filling = filling;
    }

    //public property (everyone can use...)
    //? get -> read (data)
    //? set -> write to (data)
    public string Filling
    {
        get
        {
            return _filling.ToUpper();
        }
        set
        {
            _filling = value;
        }
    }
    public string Topping { get; set; }
    public decimal Price { get; set; } = .25m;
    public bool IsSpecial { get; set; } = false;

    //make a method that will return the value of the private field (line 13) -> old school
    public string GetDonutType()
    {
        return _donutType;
    }

    //allows us to change _donutType  -> old school
    public void SetDonutType(string type)
    {
        _donutType = type;
    }
}
