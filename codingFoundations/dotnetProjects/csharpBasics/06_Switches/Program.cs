﻿//* Switch statement

/*
*   3 Parts:
*   1. 'switch' keyword
*   2. a value that is being evaluated
*   3. 'case' keyword, indicates the block of code that will be executed if the
*       value matches the given case.
*   4. 'break' keyword, indicates the end of the case
*   5. 'default', if ALL ELSE FAILS
*/

//Ex:
string name = Console.ReadLine();

//use the switch statement
// switch(name)
// {
//     case "Pete":
//     case "pete":
//     case "Danny":
//     case "danny":
//      System.Console.WriteLine($"Hi, {name}");
//      System.Console.WriteLine("...We can still run other stuff!!!");
//     break;

//     so, if ALL ELSE FAILS....
//     default:
//     System.Console.WriteLine("Invalid Option!");
//     break;
// }

//* real example:
System.Console.WriteLine("How are you feeling (1-5)");

int feelingRating = int.Parse(Console.ReadLine());

//what if the user types a name...

switch (feelingRating)
{
    case 5:
    System.Console.WriteLine("Thats great to hear.");
    break;
    case 4:
    System.Console.WriteLine("Good Stuff!");
    break;
    case 3:
    System.Console.WriteLine("Hope things improve!");
    break;
    case 2:
    System.Console.WriteLine("Oh, sorry to hear that!");
    break;
    case 1:
    System.Console.WriteLine("Dang, Hope your day gets better!");
    break;
    default:
    System.Console.WriteLine("Sorry, we don't understand. Please try again later");
    break;
}

// try
// {
//     feelingRating = int.Parse(Console.ReadLine());

//     switch (feelingRating)
//     {
//         case 5:
//             System.Console.WriteLine("Thats great to hear.");
//             break;
//         case 4:
//             System.Console.WriteLine("Good Stuff!");
//             break;
//         case 3:
//             System.Console.WriteLine("Hope things improve!");
//             break;
//         case 2:
//             System.Console.WriteLine("Oh, sorry to hear that!");
//             break;
//         case 1:
//             System.Console.WriteLine("Dang, Hope your day gets better!");
//             break;
//         default:
//             System.Console.WriteLine("Sorry, we don't understand. Please try again later.");
//             break;
//     }
// }
// catch (Exception ex)
// {
//     System.Console.WriteLine(ex.Message);
// }
