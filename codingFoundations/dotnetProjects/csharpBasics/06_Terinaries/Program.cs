//* Ternary Expressions (THE ONE LINER CONDITIONAL)

//conditional operator

//Syntax
//1          //2                   //3
//boolean expression ? expression if true : expression if false

/*
*   1. boolean expression to be evaluated
*   2. seperates the boolean and the true result
*   3. seperates the true/false results
*/

//Ex:
System.Console.WriteLine("Enter your age: ");
string response = Console.ReadLine();  //gives back a string

int age = int.Parse(response);

//output:
string output = (age >= 18) ? "You can vote!" : "You're too young to vote.";

//but we can explore:
// DON'T BE AFRAID TO FAIL...B/C...ITS DEFINTELY APART OF THE PROCESS!!!!
string output2 = (age >= 18) ? "You can vote!" : (age >= 0 && age <= 10) ? "Dude, your still a child" : "Man, I can't wait to vote!";

System.Console.WriteLine(output);