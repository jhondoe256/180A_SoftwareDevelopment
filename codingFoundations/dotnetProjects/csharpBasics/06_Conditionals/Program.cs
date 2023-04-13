//*Conditionals
//todo: handles making decisions in your application
//* Operates on specific conditions

//* Ex:
// If the user is logged in, redirect them to the login page
// If its the users birthday, wish them happy birthday 
// If the  user doesn't have the required role, then deny them access

bool isRaining = true;
bool isGoingOutside = true;

//If statements:
//formula:
// Given a boolean, if the boolean evalueates to 'true' then do the action you are given

//* if statement syntax:
//  if(true/false value)
// {
//   Body of the code, we'll execute this if above value evaluates to true
// }

//(isRaining == true) 
if(isRaining)
{
    System.Console.WriteLine("It's raining out");
}

//Multiple if statements
// AND (&&)
if(isRaining && isGoingOutside)
{
    System.Console.WriteLine("Better bring an umbrella.");
}

//OR (||)
if(!isRaining || isGoingOutside==false)
{
    System.Console.WriteLine("I don't need an umbrella.");
}

// XOR
if(isRaining ^ isGoingOutside)
{
    System.Console.WriteLine("I will only go outside if its not raining");
}

//Multi-If-statement

bool hasUmbrella = true;
if(hasUmbrella && isGoingOutside && isRaining)
{
    System.Console.WriteLine("Good thing I have my umbrella, so that I can go outside while its raining!");
}