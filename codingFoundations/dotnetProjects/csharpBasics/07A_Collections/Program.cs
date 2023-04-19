//* C# Collections (these are just collections)

//* Everything in C# is an object!!!!!
object[] stuff = new object[5];  //this can only hold 5 objects!!!

//Arrays start at 0
stuff[0] = "Terry";
stuff[1] = 1;
stuff[2] = 44.75f;
stuff[3] = "Bill Bob";
stuff[4] = new String("BLAH");

System.Console.WriteLine(stuff[4]);

//!^ DO NOT DO THE ABOVE CODE!!!!!

//* We need type Safety!!!

//* Array -> Collection and its a FIXED SIZED collection!
//* lets pick on string
//* This is a collection of characters (char)
string stringExample = "Hello World";
System.Console.WriteLine(stringExample[5]);
System.Console.WriteLine(stringExample[4]);

//Array of type string
// these are really QUICK when it comes to READING THE DATA
// the are really SLOW, when it comes to DATA MODIFICATION
// b/c there will always be a COPY not the ORIGINAL....
// object initialization
string[] stringArray =
{
    "Hello",  //0
    "World",  //1
    "why",    //2
    "is it",  //3
    "Always", //4
    stringExample, //5
    "?" //6
};

string thirdItem = stringArray[3];
System.Console.WriteLine(thirdItem);  // 'is it'

stringArray[0] = "Hey there.";
System.Console.WriteLine(stringArray[0]);

//* -- List<T> 
//*  System.Collections.Generic (using statement (goes to the top of the file...))

List<string> listOfStrings = new List<string>();
List<int> listOfIntegers = new List<int>();

// lets add to listOfStrings....
listOfStrings.Add("The first string in our list!");  // index 0
listOfStrings.Add("This is the second string!");    // index 1

System.Console.WriteLine(listOfStrings[0]);
System.Console.WriteLine(listOfStrings[1]);

// lets add to listOfIntergers....
listOfIntegers.Add(1111);  //0
listOfIntegers.Add(2222);  //1
listOfIntegers.Add(3333);  //2

System.Console.WriteLine(listOfIntegers[2]);

//* --Queues<T>
//* Think of a line at the grocery store
//* Whoever is first in line is the first to be serviced.

// F.I.F.O 
Queue<string> firstInFirstOut = new Queue<string>();

//ADDING TO THE QUEUE
firstInFirstOut.Enqueue("I'm First!");
firstInFirstOut.Enqueue("I'm Second!");

//How do we see who is next in line...
string seeWhosNext = firstInFirstOut.Peek();

System.Console.WriteLine($"Who is next in line: {seeWhosNext}");

// removing an item .Dequeue()
string removedItem = firstInFirstOut.Dequeue();
System.Console.WriteLine($"Who just got removed: {removedItem}");

//make sure that it got removed...
string whoIsNextInLine = firstInFirstOut.Peek();
System.Console.WriteLine($"Who is next in line: {whoIsNextInLine}");

// System.Console.WriteLine($"*See whos next in line* Who is next in line: {seeWhosNext}");

//* -- Dictionary <TKey,TValue> (key/value pair)
//* 1 can only be ONE KEY!!!!

Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

//so, how do we add to this????
keyAndValue.Add(0, "First Value");
keyAndValue.Add(2, "Second Value");
// keyAndValue.Add(2,"Second Value To EXPLODE!!!");

System.Console.WriteLine(keyAndValue[2]);

//Stack<T> - L.I.F.O (Last in First Out)

Stack<string> stackOfStrings = new Stack<string>();

//how do we add to the stack?
stackOfStrings.Push("First Plate, I'll be last....");
stackOfStrings.Push("Second Plate, I'll be second....");
stackOfStrings.Push("third Plate, I'll be first....");

System.Console.WriteLine(stackOfStrings.Peek());  //113 => third plate

//lets remove a plate...
string firstPlate = stackOfStrings.Pop();
System.Console.WriteLine($"Terry took the {firstPlate}");

System.Console.WriteLine(stackOfStrings.Peek()); //112 => second plate


// Other Collections: 
SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
HashSet<int> uniqueList = new HashSet<int>();

//-------- random Numbers

Random rng = new Random();

//random number between 5 and 20.
// firstNumber: Inclusive, secondNumber: Exclusive
int randomNumber = rng.Next(5, 21);
System.Console.WriteLine(randomNumber);