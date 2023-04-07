// Dynamic Object Behavior

//Object literal
const character ={
    characterName : "bill"
};

console.log(character);

//* We can always add properties/Methods to existing objects!
//* We are not STUCK  with just theinitial setup of an object

character.isFeared = true;
character.wageWar = function(){
    return "Its war time!!!!"
};

console.log(character);


//todo: what if you want to delete a property?

delete character.isFeared;
delete character.wageWar;

console.log(character);

