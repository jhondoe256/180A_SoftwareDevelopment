//Logical Operators without booleans

console.log(false || 'Terry'); //'Terry'
console.log(false || 100);     //100

// the result of logical expression is not necessarily 'true' or 'false'
// this depends on the value of the 'operands' and they can be
// 'truthy' or 'falsey'

//* Falsey (false) -> if any of these are used in a logical expression:
//*  undefined
//*  null
//*  0
//*  false 
//*  '' -> empty string 
//*  NaN -> mathamatical value that isn't valid

// ANYTHING THAT IS NOT FALSY, IS TRUTHY

//in the above code (line 3) console.log(false || "Terry"). the value Terry is 
// returned b/c it's truthy! 

//what if:
console.log(false || 1 || 2);
//* Short-Circuting, once the expression 'hit' the value of 1 everything else stops when
//* it come to implementing this expression.


let defaultCharacter = "Default Character";
let characterA = "Bill";
let characterB = "Ted";

let userSelection = null;  //waiting on user to make a selection;

let characterSelection = userSelection || defaultCharacter;

console.log(characterSelection);