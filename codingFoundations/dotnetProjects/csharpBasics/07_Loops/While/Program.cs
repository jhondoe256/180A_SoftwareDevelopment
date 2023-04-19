//* While Loop


// for (int i = 0; i < number; i+=5)
// {
// 
//     System.Console.WriteLine(i);
// }


//setup a while loop
int number = 0; //start here!

//boolean expression, as long as this is true, the loop will run
while (number <= 100)
{
   
    System.Console.WriteLine(number);
    //! WE NEED A WAY OUT OF HERE!!! NO INFINITE LOOPS HERE!
    number += 5;
}

//Infinate loops (our enemy....) ctrl+c to stop an infinate loop in the terminal!!!!
// while(number == 0)
// {
//     System.Console.WriteLine("Oh, Crap!");
// }

//? What about 'break and continue' ... and return

int value2 = 11;

while (value2 > 0)
{
    value2--; // value2 = value2 - 1;
    if (value2 == 90)
    {
        System.Console.WriteLine($"{value2}, We're JUMPING OUT OF THIS LOOP!");
        break; // this makes us jump out of he while loop.
    }
    if (value2 == 80)
    {
        System.Console.WriteLine($"{value2}, We'll just return (leave the loop)");
        return;
    }
    if (value2 == 10)
    {
        System.Console.WriteLine($"{value2}, We'll just carry on with the loop");
        continue;
    }

}


//do while: ALWAYS RUNS Once!!!!!
int value3 = 0;
int maxValue = 10;
do
{
    System.Console.WriteLine(value3);
    value3++; // value3 = value3 + 1;
}
while(value3 < maxValue);