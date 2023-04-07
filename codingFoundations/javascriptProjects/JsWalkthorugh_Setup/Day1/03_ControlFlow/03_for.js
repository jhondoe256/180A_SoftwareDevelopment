// the for...loop

// when we want to 'repeat' code....
// console.log("Hello world!");
// console.log("Hello world!");
// console.log("Hello world!");
// console.log("Hello world!");
// console.log("Hello world!");
// console.log("Hello world!");

//for loop 
//1. Initialized variable
//2. Conditional -> loop will run as conditional is beign met
//3. Increment Expression
//4. Body of the for-loop

//         1.         2.       3.
for(let index=0; index <= 5; index++){
    //4.
    console.log("Hello world!");
}

console.log("Another way");

for(let index=0; index < 5; index++){
    //4.
    console.log("Hello world!",index);
}

console.log("Using Modulo");

for(let i = 0; i <=20; i++){
    if(i%2 === 0){
        console.log(i);
    }
}

for(let i = 0; i <=20; i++){
    if(i%3 === 0){
        console.log(i);
    }
}

console.log("Loop in reverse");

for(let j=10; j > 0; j-=2){
    console.log(j);
}