//* For Loops

// while the boolean expression evaluates to true, lets execute a statement

//Syntax: 
//for (initializer; condition; iterator)
//{
//  body
//}

//Ex:
int number = 3;

//1   //2       //3        //4
for (int i = 0; i < number; i++)
{
    //5
    System.Console.WriteLine(i);
}

/*
*   1. -For Keyword
*   2. -Declaration of the variable
*   3. - Boolean expression that only runs if it's true
*   4. - Increment of the iterator at the end of each loop
*   5. - Body of the loop (what's performed)
*/

//Ask the user for a specific value (1-10)
System.Console.WriteLine("Give me a number from 1-10.");

//get user input 
int userInput = Convert.ToInt32(Console.ReadLine()!);

//? want to start at zero, and count up to whatever integer value the user puts in
for (int i = 0; i <= userInput; i++)
{
    System.Console.WriteLine(i);
}

