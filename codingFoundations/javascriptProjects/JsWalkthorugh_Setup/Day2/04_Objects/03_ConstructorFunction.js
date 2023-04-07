//Constructor function: construct or create an object

//* FACTORY FUNCTION
function createCharacterRefactor(characterName,isFeared){
    return {
     characterName,
     isFeared,
     wageWar(){
         return "Its war time!!!!";
     }
    } 
 }


 //?  SO WHAT'S DIFFERENT?
//Pascal Casing: Uppercase FirstLetterOfFirstWord
 function CharacterCreate(characterName)
 {
    this.characterName = characterName;     //'this' is referencing the obj that is executing this piece of code
    this.wageWar = function(){
        return "Its war time!!!!";
    }
    return this; //todo: we don't really need this line of code.
}

//Calling the constructor function
const character = new CharacterCreate("bill bob");

//^ whats happening?
//* 1. using the 'new' keyword -> this creates an empty object
//* 2. 'this' is 'pointing' to the empty object
//* 3. returns the object from the function (CharacterCreate)
const a ={}; //this is the new in action in the background when you 'new up' something


console.log(character);



