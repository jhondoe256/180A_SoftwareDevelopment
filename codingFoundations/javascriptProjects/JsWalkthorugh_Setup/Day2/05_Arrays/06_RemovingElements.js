//Removing Elements From an Array

const values = [10,20,30,40,50];


console.log(values);

//? remove the first value:

let firstValueRemoved = values.shift();
console.log(firstValueRemoved);

//? remove stuff from the middle
let middleRemovedValue = values.slice(1,2);
console.log(middleRemovedValue);


//? remove stuff from the end
let lastValueRemoved = values.pop();
console.log(values);
console.log(lastValueRemoved);

