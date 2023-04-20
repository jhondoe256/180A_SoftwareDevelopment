

//lets make some vehicles!!!

Vehicle veh1 = new Vehicle();
veh1.Model = "Mustang";

Vehicle veh2 = new Vehicle();
// veh2.Model = "Camero";

// veh1.TurnOn();

// //this one won't work, doesn't serve the condition
// veh2.IndicateRight();

// //this one will work, servers the condition
// veh1.IndicateRight();

// veh1.TurnOnHazzards();

// veh1.ClearIndicators();


//quick look
if (veh1 == veh2)
{
    System.Console.WriteLine("These guys are equal");
}
else
{
    System.Console.WriteLine("nah, no there not!");
}


//Do these guys "point" to the same memory address
if (veh1.GetType() == veh2.GetType())
{
    System.Console.WriteLine("These guys are equal");
}
else
{

    System.Console.WriteLine("nah, no there not!");
}