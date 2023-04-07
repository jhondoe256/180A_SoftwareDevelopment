//For...In loops => loop over properties of an object
// we can get the data in two ways

//* Dot notation
//* car.Make

//* Bracket notatation
//* car["Model"]

//obj literal syntax
const car = {
    model:"Mustang",
    make: "Ford"
};

console.log("Display the 'keys' ");

for(let key in car){
    console.log(key);
}

console.log("Display the 'keys' and 'values' ");
for(let key in car){
    console.log(key,car[key]);
}

const colors = ['red','green','blue']; //[0,1,2]

for(let index in colors){
    console.log(index);
}

for(let index in colors){
    console.log(index, colors[index]);
}