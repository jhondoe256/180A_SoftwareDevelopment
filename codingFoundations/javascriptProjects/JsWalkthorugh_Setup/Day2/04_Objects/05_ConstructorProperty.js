// Every obj in Js has a property called Constructor
// references the function that was used to create or 'construct' the object

//Constructor Pattern
function Character(characterName,isFeared){
    this.characterName=characterName;
    this.isFeared=isFeared;
    this.wageWar= function(){
        return "It's war time!!!"
    }
}

const characterB = new Character("Jessie V",false);

console.log(characterB.constructor);

//Whats happening in the background: 
let x={};  //-> empty obj, we'll use the character constructor when the above object is created


//There are pre-built Constructors in Js
new String();    // string (collection of char)
new Boolean();   // true/false
new Number();   // 1,2,3

let mystring = new String('????');
console.log(mystring);

let mystring02 = '????_02';