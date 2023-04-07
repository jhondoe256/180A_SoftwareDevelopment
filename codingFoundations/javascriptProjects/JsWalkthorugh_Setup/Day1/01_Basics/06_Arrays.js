// Array -> data structure that is used to represent a collection of items.

                    //    0         1
let videoGameConsoles =['PS5','XBOX-SERIES X'];
console.log(videoGameConsoles);

//arrays contain indicies, which allows us to access specific locations w/n the array
// arrays start at index 0
// and we count up from there

//'PS5'
console.log(videoGameConsoles[0]);

//'XBOX-SERIES X
console.log(videoGameConsoles[1]);  

//todo: we can still change these values... lets add another console 
videoGameConsoles[2]= 'Super-Nintendo';

console.log(videoGameConsoles);

videoGameConsoles[5]= 'Game Cube';

//todo: you can put WHATEVER type you want in a Js Array
videoGameConsoles[4]= 33.33;
console.log(videoGameConsoles);

//? what kind of type is videoGameConsoles
console.log(typeof videoGameConsoles);

//todo: when you want to know how many items are in an Array?
console.log(videoGameConsoles.length);  // length -1 