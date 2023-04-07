// Value types  and Reference types


//todo: Value types (Primatives)

let x = 20;

let y = x;

x=50;

console.log(x);   //50

console.log(y);  // 20

//* Primatives:
//* 1. Values are stored w/n the variable
//* 2. line 8, the value of 20 is being stored in the variable y,
//* eventhough y = x , they are THEY ARE TOTALLY INDEPENDANT VARIABLES

//todo: Reference types: Objects....

let obj1 = {value:20};
let obj2 = obj1;             //  --> these point to the same addess in Memory 

obj1.value =50;
obj2.value =51;

obj2.value=100;
obj1.value=200;

console.log(obj1);
console.log(obj2);
