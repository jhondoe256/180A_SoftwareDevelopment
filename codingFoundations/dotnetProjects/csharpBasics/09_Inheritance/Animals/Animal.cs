//1. This is our BASE CLASS
//2. I want other class to 'derive / inherit' from me
//3. I do not want the user/developer to be able to make instances (copies) of me (abstract)

public abstract class Animal
{
    //create the constructor manually
    public Animal()
    {
        System.Console.WriteLine("This is the Animal Constructor.");
    }

    //define the attributes of the Animal
    public int NumberOfLegs { get; set; }

    public bool IsMamal { get; set; }

    public bool HasFur { get; set; }

    public DietType DietType { get; set; }

    public virtual void Move()  // virtual keyword allows you to "override" defalut parent behavior
    {
        System.Console.WriteLine($"This {GetType().Name} moves.");  //? GetType() -> Animal
    }
}
