//* Methods

//* Usually made w/n a class, but we'll make some here for example sake

//* Small machines that can perform modular tasks 

//* Sometimes, they can do work and give you stuff back (return)

//* Otherwise, they will just 'do work'
//* our first method
//* this method 'returns' NOTHING -> 'void'

// public void SayHello(string name)
// {
//     //* do some work, and THATS IT!
//     Console.WriteLine($"Hello {name}!");
// }

//* invoke/call the method
//SayHello("Terry Brown");
//SayHello("Bill Burr");

//? what if we want a method that gives 'something back'

int AddMe(int valueA, int valueB)
{
    //make a new variable that will hold the expression and the value
    int ans = valueA + valueB;
    return ans; //returned value for 'future use'
}

//let use it!
int sum = AddMe(2, 5);
System.Console.WriteLine($"sum: {sum}");

int SubtractMe(double valueA, double valueB)
{
    double ans = valueA - valueB;
    return Convert.ToInt32(ans);
}

int subt = SubtractMe(20.42, 10.33);
System.Console.WriteLine($"ans: {subt}");


double SquareMe(int value)
{
    double ans = value * value;
    return ans;
}

double sqResult = SquareMe(3);
System.Console.WriteLine($"ans: {sqResult}");


System.Console.WriteLine(SquareMe(AddMe(10, 2)));


int CrazyMath_AddUs(params int[] values)
{
    int startingPoint = 0;

    //loop through the values and add them....
    foreach (int value in values)
    {
        startingPoint += value;
    }

    //after everything has been added, lets return the results
    return startingPoint;
}

int addValues = CrazyMath_AddUs(11, 20, 10, 12, 100, 200, 375);
System.Console.WriteLine($"addValues: {addValues}");

Random rnd =new Random();
void GetRandomGreeting()
{
    //count of an array -> .Length property
    string[] availableGreetings =
    {
        "Hello",  //0
        "Howdy", //1
        "Holla", //2
        "Yo",    //3
        "Greetings" //4
    };

    //get a random number (index)
    //0 is inclusive, and 5 (.length) is exclusive
    // this will only go from 0 - 4
    int randomNumber = rnd.Next(0,availableGreetings.Length);

    //lets assign the randomNumber value to an availableGreetings[index]
    // string randomGreeting = availableGreetings.ElementAt(randomNumber);
    string randomGreeting = availableGreetings[randomNumber];

    System.Console.WriteLine($"{randomGreeting}");
}

//call it!
GetRandomGreeting();