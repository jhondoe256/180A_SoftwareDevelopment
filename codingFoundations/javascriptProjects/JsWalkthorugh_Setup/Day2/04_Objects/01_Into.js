//Into to Object oriented programming (OOP)

// Style of progrmming where the program is utilizing a collection of objects 
// that interact with one another to perform some functionality.

//* character for video game

let characterName = "Ted";
let motto = "I am king!!!";
let weapon = 'sword';

/*
 *  this is cool, but not good enough,
    we want an Object!!!
 */

//object literal syntax
const gameCharacter = {
   characterName : "Ted",      //string
   motto:"I am King",          //string   
   weapon: "Sword",           //string
   kindom:{                   // object
    realm:"Shadow",
    country:"USA"
   }, 
   isFeared: false,        // boolean (bool)
   wageWar:function(){     //Method (function w/n an object)
    console.log("It's war time!!!");
   }
}


gameCharacter.wageWar();

console.log(gameCharacter.kindom);
console.log(gameCharacter.kindom.country);
console.log(gameCharacter["kindom"]);