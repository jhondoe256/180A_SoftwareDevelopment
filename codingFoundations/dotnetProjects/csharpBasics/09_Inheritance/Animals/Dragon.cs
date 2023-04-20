
public class Dragon : Animal
{
    public Dragon()
    {
        HasFur = false;
        IsMamal = false;
        DietType = DietType.Carnivore;
    }
}

public class IceDragon : Dragon, IIceBlastable
{
    public IceDragon()
    {
        HasFur = false;
        IsMamal = false;
        DietType = DietType.Carnivore;
    }

    public void IceBlast()
    {
        //... I can shoot ice out my mouth!!!!
    }
}

public class MegaDeath : Dragon, IIceBlastable, IBorrowable
{
    public MegaDeath()
    {
        HasFur = true;
        IsMamal = false;
        DietType = DietType.Herbivore;
    }

    public void BorrowUnderGround()
    {
        // borrow underground, regain health and frees the uppersurfaces of the ground
    }

    public void IceBlast()
    {
        //I shoot out baby dragons that breath ice!!!
    }
}

public class Wyrm : Dragon , IBorrowable
{
    public Wyrm()
    {
        NumberOfLegs = 0;
    }

    public void BorrowUnderGround()
    {
        //I burrow underground and regan health....
    }

    public override void Move()
    {
        System.Console.WriteLine("Im crawling and I can't get up!!!!");
    }

   
}

public class Hydra : Dragon
{
    public int HeadCount { get; set; } = 5;
}
