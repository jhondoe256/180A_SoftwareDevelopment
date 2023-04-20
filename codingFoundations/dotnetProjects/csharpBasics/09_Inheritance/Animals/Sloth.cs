
public class Sloth : Animal
{
    public Sloth()
    {
        System.Console.WriteLine("Sloth Constructor.");
    }


    //public bool IsSlow { get{ return true; } }

    public bool IsSlow
    {
        //I want to omit the set; (setter), b/c I only want the compiler to 'read' the data
        get
        {
            return true;
        }
    }

    public override void Move()
    {
        System.Console.WriteLine("The Sloth moves Slowly!");
    }
}

public class Megatherium : Sloth
{
    public Megatherium()
    {
        System.Console.WriteLine("This sloth is extinct");
    }
    public override void Move()
    {
        System.Console.WriteLine("Megatherium uses Move! It's not super effective...???");
    }
}
