// Sorting Array

const values = [22,12,14];

values.sort();

console.log(values);

const reverseValues = values.reverse();
console.log(reverseValues);


console.log("======================");

const cars = [
    {id: 1, Make:'Ford',Model:'Mustang'},
    {id: 2, Make:'apple',Model:'Apple-Car'}
]

//sort by make

// this gets two objects (a,b) and will make a comparison
//  
let sortedCars = cars.sort((a,b)=>{
    // a < b => -1
    // a > b => 1
    // a === b => 0

    const makeNameConverstionA = a.Make.toLowerCase();
    const makeNameConverstionB = b.Make.toLowerCase();

    if(makeNameConverstionA < makeNameConverstionB) return -1;
    if(makeNameConverstionA > makeNameConverstionB) return 1;
    return 0;

    //not using else..if b/c if the first condition is true we want to jump out here
    // controll we never move to any next point in this block of code.

});


console.log(sortedCars);

