//C# Types

//? Value type  (structs) -> immutable (the literal value cannot be changed!!), the value of 4 will ALLWAYS BE 4
//? default to 0. 

//bool -> (boolean) true/false
// our variables will be 'camelCasedToPerfection'
bool isLoggenIn = true;
System.Console.WriteLine(isLoggenIn);

//integers, or int -> these are whole numbers
int age= 42;
System.Console.WriteLine(age);

//decimal -> very percise (money)
//we need a suffix after the value (m,M)
decimal accountBalance = 9000.01m;
decimal accountBalance2 = 9000.01M;
decimal accountBalance3 = 9000_01m;
System.Console.WriteLine(accountBalance);

int i =0;             //32 bit integer value
short sh = 32767;    //16 bit integer value
Int16 anotherShort = 32000; 
byte by = 255;       // this is a group of binary digits (usually eight) operated on a unit.

string s = "hey!";  //collection of characters
                    // this is a reference type (default to null)

char c = 'i';       //represents a single character

string s2 = @"a:\NewFolder\something.jpg";  //@ to specify a directory
// string s2 = "a:\\NewFolder\\something.jpg";

bool b = false;   //true or false value

long L =7;        //is a LARGE integer value. x2 more LARGE. 
                 // -9_223_372_036_854_775_808 to 9_223_372_036_854_775_807
                 //(nine quintillion two hundred twenty-three quadrillion three hundred seventy-two 
                 //trillion thirty-six billion eight hundred fifty-four million 
                 //seven hundred seventy-five thousand eight hundred seven)

decimal d = 99.999999m;  //'m' 128-bit percision, has a range of 28-29 decimal places

double db = 7.800000d;  // 'd' has 15-16 digit percision with a 64-bit size 

float f = 10.8f;   //'f' stored in 32-bits, its half the size of a double

int? ni = null;  // A '?' after the type allows the value to be null (nothing)


//Dealing with Decimals
//we can type as many decimal places that we want for a given type
//but, things change during compile time (dotnet run....)
Console.WriteLine(1.2578907289045789789789789787897f);
Console.WriteLine(1.2578907289045789789789789787897d);
Console.WriteLine(1.2578907289045789789789789787897m);

//Enums 
//use our pastry types
PastryType myPastry = PastryType.Croissant;
System.Console.WriteLine(myPastry);
System.Console.WriteLine((int)myPastry);

PastryType anoterPType = PastryType.Cupcake;
System.Console.WriteLine(anoterPType);

//Dates...
DateTime today = DateTime.Today;
System.Console.WriteLine(today);

DateTime birthDay = new DateTime(2027,12,11);
System.Console.WriteLine(birthDay);

//? Reference type (class) -> 'pointers', point to a specific loction in memory. (defaults to null)
