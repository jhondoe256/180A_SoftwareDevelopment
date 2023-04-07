//if and else 

// I want to print out how I feel about a dog breed

let userSelection = "american bully";
let response; //undefined Js engine doesn't know 

// check if user screws up

if(userSelection === "" || userSelection === null)
    response = "Sorry, Invalid Selection";

    else if((userSelection === "American Bully".toUpperCase()) || (userSelection === "American Bully".toLowerCase()))
    response= "Ah, now thats a wonderful pet!";

    else if(userSelection === "Siberian Husky")
    response ="Ah , now that's a pet you have to be 'VERY INVOLVED' with!";

    else if(userSelection=== "Doberman Pinscher")
    response= "Ah.....!";

    else
    response = "???";


console.log(response);