//Arithmetic operator

//addition (+)
decimal bankAccount = 5000.00m;
decimal deposit = 100.00m;

System.Console.WriteLine(bankAccount+=deposit);

// decimal todayTotalValue = bankAccount + deposit;
// System.Console.WriteLine(todayTotalValue);

//subtraction (-)
decimal phoneBill = 120.00m;
// decimal grandTodayTotal = todayTotalValue - phoneBill;
// System.Console.WriteLine(grandTodayTotal);
System.Console.WriteLine(bankAccount-=phoneBill);  // bankAccount = bankAccount - phoneBill;

//multiplication (*)
decimal multValue = 3 * 3;
System.Console.WriteLine("multValue: " + multValue);

//division (/)
int markers = 300;
int students =30;
int divideByStudents = markers / students;
System.Console.WriteLine(divideByStudents);

//Modulo (%)
int modValue = 10%3; //remainder of 1
int modValue2 = 10%2; //remainder of 2
System.Console.WriteLine(modValue);

//Unary Operators
int studentCount = 30; 

///...later on on 'code-land'....
//I just want to add ONE STUDENT
studentCount++;
System.Console.WriteLine(studentCount);

//I just want to subtract by one
studentCount--;
System.Console.WriteLine(studentCount);

//More Examples:

//addition
int additionResult = 5+2;
System.Console.WriteLine(additionResult);

//subtraction:
int subtractionResult = 5-2;
System.Console.WriteLine(subtractionResult);

//multiplication
int multiplicationResult = 5*2;
System.Console.WriteLine(multiplicationResult);

//division
int divisionResult = 5/2;
System.Console.WriteLine("5/2 = "+ divisionResult);

//Modulus
System.Console.WriteLine(10%2);  //0

System.Console.WriteLine(10%9);  //1

System.Console.WriteLine(10%3);  //1

System.Console.WriteLine(10%5);  //0


