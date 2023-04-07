//Finding Primitives in Js

const pValues = [10,9,8,7,8];

// display the index

console.log(pValues.indexOf(7));   //3
console.log(pValues.indexOf("terry"));   //-1 value doesn't exist w/n the array
console.log(pValues.indexOf("9"));   //-1 b/c its a string type
console.log(pValues.indexOf(8));   //2 b/c its the first time 8 shows up w/n the array

console.log(pValues.indexOf(9) !== -1);  //old way

console.log(pValues.includes(9));   

