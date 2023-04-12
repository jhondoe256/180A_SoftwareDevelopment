//* Strings

/*
*  Just a collection of characters, and they are stored an used throughout the entire application
*  Almost any text, single character, or number can be a string


todo: In C# we ititialize a string by using ("") wrapped around the value

todo: 3 to use a string type
    ? Concatenation
    ? Composite Formatting
    ? Interpolation
*/

//Concatenation Ex:
string first = "The cars we sell are";
string second = "BMW, Lexus, and Mercedes.";

string concatenatedResult = first + ' ' + second;
System.Console.WriteLine(concatenatedResult);


//Composite Formatting
string firstName = "Jenn";
string lastName = "Williams";

string compositeResult = string.Format("Her name is {0} {1}.",firstName,lastName);
System.Console.WriteLine(compositeResult);

//String Interpolation
string interpolationResult = $"Her name is still {firstName} {lastName}.";
System.Console.WriteLine(interpolationResult);
