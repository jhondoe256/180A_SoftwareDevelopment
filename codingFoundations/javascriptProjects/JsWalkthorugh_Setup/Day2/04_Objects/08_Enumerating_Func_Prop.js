// Enumerating function properties

const character= {
    characterName: 'bill',
    isFeared:false,
    wageWar(){
        return "I delclair war!";
    }
}

// loop over the properites/Methods of this obj
for(let key in character){
    console.log(key,character[key]);  // brackets will get the value
}

console.log("-- getting keys ---");

//gives back the keys
for(let key of Object.keys(character)){
    console.log(key);
}

console.log("-- getting keys and values ---");

// get key value pair
for(let entry of Object.entries(character)){
    console.log(entry);
}

//can use the 'in' loop to see if a property exist
console.log("-- see if property exists... ---");
if('characterName' in character) {
    console.log('yes');
}