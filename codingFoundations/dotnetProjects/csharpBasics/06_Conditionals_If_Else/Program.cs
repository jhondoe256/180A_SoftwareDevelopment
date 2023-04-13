//what happens if an 'if' statements conditions aren't met.

bool isRaining = true;

//Example
if (!isRaining)
{
    System.Console.WriteLine("I'll go cut the grass!");
}
else //default -> if all else fails... we do this
{
    System.Console.WriteLine("I'm staying in bed!...Yay!");
}

System.Console.WriteLine("------------------------------------");

if (!isRaining)
{
    System.Console.WriteLine("I'll go cut the grass!");
}

if(isRaining) 
{
    System.Console.WriteLine("I'm staying in bed!...Yay!");
}

System.Console.WriteLine("--------------- if / else---------------------");

bool isGoingOutside = false;

if(isGoingOutside) // isGoingOutside == true
{
    System.Console.WriteLine("Please dress for the weather.");
}
else
{
    System.Console.WriteLine("Seems like a sweats kind of day.");
}

System.Console.WriteLine("--------------- if/else if/else if / else---------------------");

if(isGoingOutside)
{
     System.Console.WriteLine("Please dress for the weather.");
}
else if(isGoingOutside && isRaining)
{
        //do some code....
        System.Console.WriteLine("I'm running outside shirtless.");
}
else if(isRaining==false)
{
        //do some other code....
        System.Console.WriteLine("Man, it's raining cats and dogs!");
}
else
{
     System.Console.WriteLine("Seems like a sweats kind of day.");
}

System.Console.WriteLine("--------------- More if/else ---------------------");

//Ask the user how are they feeling?
System.Console.WriteLine("How are you feeling (1-5) ?");

//we need to get 'user input' Console.ReadLine()
string value = Console.ReadLine();

// int intValue = int.Parse(value);

//if...elseif...
if(value == "1")
{
    System.Console.WriteLine("Dang, We hope you day gets better!");
}
else if(value == "2")
{
    System.Console.WriteLine("Oh, sorry to hear that.");
}
else if(value == "3")
{
    System.Console.WriteLine("Hope things improve!");
}
else if(value == "4")
{
    System.Console.WriteLine("Good Stuff");
}
else if(value == "5")
{
    System.Console.WriteLine("That's great to hear!");
}
else
{
    System.Console.WriteLine("Invalid Key Entry!");
}
