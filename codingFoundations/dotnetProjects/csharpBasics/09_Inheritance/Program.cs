
//this is the ENTRY POINT OF ALL APPLICATIONS
Cat tom = new Cat();

tom.Move();
tom.MakeSound();
System.Console.WriteLine(tom.DietType);

System.Console.WriteLine();

TabbyCat tCat = new TabbyCat();
tCat.ClawLength = 1.27;
System.Console.WriteLine(tCat.DietType);

System.Console.WriteLine();

Liger lig = new Liger();
lig.ClawLength = 5.38;
lig.Move();
lig.MakeSound();
System.Console.WriteLine(lig.DietType);

System.Console.WriteLine("======== Dragons ===========");
Dragon drag01 = new Dragon();
drag01.Move();
System.Console.WriteLine(drag01.DietType + " ," + drag01.HasFur);

Wyrm wym1 = new Wyrm();
wym1.Move();

Hydra hydra1 = new Hydra();

System.Console.WriteLine($"Dude, it has, {hydra1.HeadCount}");

System.Console.WriteLine("======== Sloths ===========");
Sloth sloth1 = new Sloth();
sloth1.Move();

Console.WriteLine();

Megatherium mSloth = new Megatherium();
mSloth.Move();
