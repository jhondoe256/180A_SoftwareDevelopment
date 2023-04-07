//object literal syntax
// const gameCharacter = {
//     characterName : "Ted",      
//     motto:"I am King",          
//     weapon: "Sword",           
//     kindom:{                   
//      realm:"Shadow",
//      country:"USA"
//     }, 
//     isFeared: false,      
//     wageWar:function(){     
//      console.log("It's war time!!!");
//     }
//  }

//* We need to have the ability to 'plug-and-play' our values

//* Factory Functions
function createCharacter(characterName, motto,weapon,realm,country,isFeared){
    return {
        characterName:characterName,
        motto:motto,
        weapon:weapon,
        kindom:{
            realm:realm,
            country:country
        },
        isFeared:isFeared
    }
}

let player1 = createCharacter('bill bob','billy bobber on the rise!','stick','wood-farms','Wooding Peak',false);
let player2 = createCharacter('Jessie Jennings','Cooking Force!','Iron Skillet','cookers-fields',null,true);

console.log(player1);
console.log('======================');
console.log(player2);

function createCharacterRefactor(characterName,isFeared){
   return {
    characterName,
    isFeared,
    wageWar(){
        return "Its war time!!!!";
    }
   } 
}

var player3 = createCharacterRefactor("dude in blue",true);

console.log(player3);
console.log(player3.wageWar());

// Dynamically create objs based on a specific 'blueprint'
// if something goes wrong, we only have to make changes in one location!