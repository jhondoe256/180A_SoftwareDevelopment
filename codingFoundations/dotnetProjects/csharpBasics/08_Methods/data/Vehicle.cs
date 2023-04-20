
public class Vehicle
{
    public Vehicle()
    {
        //allocate space in memory for these 'nested' objects
        RIndicator = new Indicator();
        LIndicator = new Indicator();
    }
    public string? Make { get; set; }

    public string? Model { get; set; }

    public double Milage { get; set; }

    public VehicleType VehicleType { get; set; }

    public Indicator RIndicator { get; set; }
    public Indicator LIndicator { get; set; }

    public bool IsRunning { get; set; }   //behind the scenes it set to 'false'

    //Methods, the ACTIONS that the object can perform!
    public void TurnOn()
    {
        IsRunning = true;
        System.Console.WriteLine($"{Model}: The vehicle is TURNED ON!!!");
    }

    public void TurnOff()
    {
        IsRunning = false;
        System.Console.WriteLine($"{Model}: The vehicle is TURNED OFF!!!!");
    }

    public void IndicateRight()
    {
        //dot operator to access properties and methods on an object
        if (IsRunning)
        {
            RIndicator.TurnOn();
            LIndicator.TurnOff();
            System.Console.WriteLine($"{Model}: Indicating Right");
        }
        else
        {
            System.Console.WriteLine("Dude, you need to turn on the car first!");
        }
    }

    public void IndicateLeft()
    {
        //dot operator to access properties and methods on an object
        LIndicator.TurnOn();
        RIndicator.TurnOff();
        System.Console.WriteLine($"{Model}: Indicating Left");

    }

    public void TurnOnHazzards()
    {
        RIndicator.TurnOn();
        LIndicator.TurnOn();
        System.Console.WriteLine($"{Model}: Hazzards Activated!");
    }

    public void ClearIndicators()
    {
        RIndicator.TurnOff();
        LIndicator.TurnOff();
        System.Console.WriteLine($"{Model}: Indicators are cleared");
    }
}
