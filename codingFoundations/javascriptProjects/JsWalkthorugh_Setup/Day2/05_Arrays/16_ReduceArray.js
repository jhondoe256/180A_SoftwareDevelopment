const values = [22, -10, 12, 14];

//calculate the total sum of numbers....
let sum = 0;
for (let v of values) {
  sum += v;
}
console.log(sum);

//we can reduce all of the elements in a Array
// into a single vlaue: can be a number, string, obj, ANYTHING.
// acc is like the 'sum' above.
// the 'call-back' function is called multi-times
// and each time the currentVal will be incremented
//this has two arguments 
//1. The call-back function
//2. The initialValue
// const reducedSum = values.reduce((acc, currentVal) => {
//   return acc + currentVal;
// },0);

const reducedSum = values.reduce((acc, currentVal) => acc + currentVal);

console.log(reducedSum);


//how does this work?

// a =0 (initialValue)
// firstRound currentVal is set to 22
// so, 0+22 = 22, then acc = 22
// nextRound currentVal is set to -10
// so, 22 -10=12 , then acc = 12
// nextRound currentVal is set to 12
// so, 12 + 12=24, then acc =24
// nextRound currentVal is set to 14
// finalRound 24+14 = 38