//Types of functions:

// Performing a task
function greetMe(firstName,lastName){
    console.log(`Hello, ${firstName} ${lastName}.`); //template literal string
}

//invoking the function
greetMe("Mr.","Magoo");


//Calculate a value/values
function squareMe(valueA){
    return valueA * valueA;  // returns value to whoever called the function.
}

let squaredNumber = squareMe(2); // returns the value 4 and stores it into squaredNumber (the variable)
console.log(squaredNumber);

console.log(squareMe(2));

let dSquared = squareMe(squareMe(4));
console.log(dSquared);


