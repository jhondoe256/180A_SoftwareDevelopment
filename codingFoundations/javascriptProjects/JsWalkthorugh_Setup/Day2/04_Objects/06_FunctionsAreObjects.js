//Functions are Objects

//Constructor Pattern
function Character(characterName,isFeared){
    this.characterName=characterName;
    this.isFeared=isFeared;
    this.wageWar= function(){
        return "It's war time!!!"
    }
}

const character = new Character('bill',true);

//the Character Function is actually an object
console.log(Character.name);  //name of the function
console.log(Character.length);  // number of arguments w/n the constructor
console.log(Character.constructor);  //who created the function


// when a function is declared, internally...
const character1 = new Function('characterName','isFeared',`
    this.characterName =characterName;
    this.isFeared = isFeared;
    this.wageWar = function(){
        return "Its war time!"
    }
`);


// now we can call character1 just like calling the Character function
const instance = new character1('instanceCharacter',true);

//this is a real character obj...
console.log(instance);

// we can call a function from Character (object)
Character.call({},1,2);

Character.apply({},[1,2]);

