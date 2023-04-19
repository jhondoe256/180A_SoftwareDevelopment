//* Foreach
//syntax:

/*
    foreach(declaredIterator in enumerableCollection)
    {
        body
    }
*/

//Ex:
string instructorName = "Amanda";

// make an enumerable collection
string[] instructors = new string[]
{
    "Michael",
    "Joshua",
    instructorName
};

//lets loop through this....
// foreach (string instructor in instructors)
// {
//     System.Console.WriteLine(instructor);
// }

//we want a collection of integers
//and we want to print out if the integer is positive or negative
int[] intArray = new int[] { 1, 2, -3, 4, 5, 0 };

foreach (int value in intArray)
{
    if (value < 0)
    {
        System.Console.WriteLine($"{value},This is a negative number.");
    }
    else if (value > 0)
    {
        System.Console.WriteLine($"{value},This is a positive number.");
    }
    else
    {
        System.Console.WriteLine($"{value},This is a neutral number!");
    }

    // switch (value)
    // {
    //     case 1:
    //     case 2:
    //     case 4:
    //     case 5:
    //         System.Console.WriteLine($"{value},This is a positive number.");
    //         break;

    //     case -3:
    //         System.Console.WriteLine($"{value},This is a negative number.");
    //         break;
    //     default:
    //         System.Console.WriteLine($"{value},This is a neutral number!");
    //         break;
    // }
}