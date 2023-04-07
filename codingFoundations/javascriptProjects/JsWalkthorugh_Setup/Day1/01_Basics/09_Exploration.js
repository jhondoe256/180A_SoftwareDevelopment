// find 3 items in your house, or somthing that you know ALL about
// make 3 obj literals based on those objects
// let access the key/values of the objs

//dog

let peaches = {
    hasFourLegs:true,
    name:'Peaches',
    age: 1,
    breed:'Boxer',
    friends:[
        'Casey',
        'Andrew',
        'Phil'
    ],
    bark:function(){                              //todo: This is a Method
        console.log("Ruff, Ruff!"); 
    }
}

console.log(peaches.name);
console.log(peaches.hasFourLegs);

console.log(`My dogs name is ${peaches.name}, her age is ${peaches['age']}, and she is a ${peaches.breed}!`);

//invoke/call the method
peaches.bark();

console.log(peaches['friends']);