//Function -> this is a small machine that does work (action)
// A Function w/n an object is called a METHOD

//1. function keyword 
//2. function name
//3. function parameters/arguments  -> parameters (firstName), variables that are defined by 'us' the
//                                     the developers
//                                  -> argument (firstName) varibles that are being passed in the function
//                                     by the user/consumer 

// 1.       2.    3.
function sayHello(){
    //body of the function 
    console.log("Hi, how are you?");
}

//call/invoke the method
sayHello();

//functions can have inputs 'passed' through them
function dynamicHello(name){
    const greeting = "Hello"+ " " + name;  // fn+F2 , but , if on desktop just F2.
    console.log(greeting);  //string concatination -> use '+' to combine strings.
}

//invoke
dynamicHello('Terry');

dynamicHello("Tim");

dynamicHello(5);

//what if I don't 'pass' in any argument
dynamicHello();