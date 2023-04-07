//Cloning objects

const character= {
    characterName: 'bill',
    isFeared:false,
    wageWar(){
        return "I delclair war!";
    }
}

// make a copy of the above object...

const another={};

//? idea... is to use a for-in loop to loop through the object and store the values in the 
//? new object

//1.

for(let key in character){
    another[key] = character[key]
}

console.log(another);

//2. Object.assign()

const another2 = Object.assign({},character);
console.log(another2);

//3. Object.assign

const another3 = Object.assign({
    horse:{
        name : 'bill bobs horse',
        isCool: true
    }
},character);

console.log(another3);


//4. using spread operator
const usingSpread = {...character};

console.log(usingSpread);