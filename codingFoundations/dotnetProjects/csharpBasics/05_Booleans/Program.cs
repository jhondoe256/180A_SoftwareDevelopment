//* Booleans

// can hold true/false

bool isCool = false;

// bool and logical operators
// Operators that perform logical operations and assessments.
//keywords: 
//todo: AND, OR ,NOT, etc.

//todo: NOT
//* C# logical Negation Operator, called the 'bang' operator (!)
//* !isCool, evaluates to the opposite of what it has been declared.
System.Console.WriteLine(!isCool);

//todo: AND
//* C# uses ampersands (&) to indicate AND statements
//* A single ampersand evaluates both conditions always,
//* A double ampersand evaluates only the right side if required.

//todo: OR
//* C# uses pipes (|) to indicate OR statements
//* A single pipe evaluates both conditions always,
//* two pipes evaluates the Left side then the Right side

//todo: XOR
//* C# use the caret (^) to indicate XOR statements.

//? Example 
//? Boolean Logical Operators

//todo: Negation Operator
bool isTrue = !false;    //true;
bool isFalse = !true;   //false

//todo: And Operator
bool trueAndExample = true && true;   //true -> both OF THESE HAVE TO BE TRUE!!
bool falseAndExample = true && false; //false

//todo: Or Operator
bool trueOrExample = true || false; // true -> b/c only one has to be true.
bool falseOrExample = false || false;

//todo: XOR Operator
bool trueExclusiveOr = true ^ false; //true;
bool falseExclusiveOr = true ^ true; //false;
bool falseExclusiveOr2 = false ^ false; //false;

System.Console.WriteLine($"NOT False = {isTrue}");
System.Console.WriteLine($"False AND True= {falseAndExample}");
System.Console.WriteLine($"True OR True = {trueOrExample}");
System.Console.WriteLine($"True XOR True = {trueExclusiveOr}");
System.Console.WriteLine($"False XOR False = {falseExclusiveOr2}");

//* Comparison Operators

//* Equal, which is two equal signs (==)

//* Not Equal (!=)

//* Greater Than (>)
//* Greater Than or Equal (>=)

//* Less Than (<)
//* Less Than or Equal (<=)


//Examples: 
bool isGreaterThan = 10 > 10;            //false
bool isGreaterThanOrEqualTo = 10 >=10;  //true
System.Console.WriteLine($"10 > 10 is {isGreaterThan}, and 10 >= 10 is {isGreaterThanOrEqualTo}");

bool isLessThan = 5 < 5 ;             //false;
bool isLessThanOrEqualTo = 5 <= 5;    //true
System.Console.WriteLine($"5 < 5 is {isLessThan}, while 5 <= 5 is {isLessThanOrEqualTo}");

            //1.    2.
bool equality = 17 == 9;
bool inequality = 17 != 9;
System.Console.WriteLine($"17 == 9 and 17 != 9 are {equality} and {inequality}, respectively.");

//1. assignment operator
//2. boolean expression