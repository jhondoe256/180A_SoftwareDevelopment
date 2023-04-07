//Dynamic -> Js variable values ARE NOT SET IN STONE


let brandName = "Nike";
let carName= 'Mustang';

let price = 200;

let hasPayed = false;

let customerName; 

let customerCart = null; 

//todo: typeof operator to see the 'types'

console.log(typeof brandName);  //string

brandName = 33;
console.log(typeof brandName); //number

//todo: these variables are subject to change at Runtime

console.log(typeof hasPayed);  //boolean

price = 330.33;
console.log(typeof price);  //number

console.log(typeof customerName);  //undefined -> value not assigned

console.log(typeof customerCart);  //object