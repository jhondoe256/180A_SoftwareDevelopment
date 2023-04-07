//Filtering an Array

const values = [22,-10,12,14];


//filtering based on a search criteria

//want positive number

let positive = values.filter(n=> n >= 0);
console.log(positive);

console.log("=== Array of Objects ==");

const classes= ['Math','Science','PhysEd'];

let clsssesWith_s = classes.filter(c =>c.toLowerCase().includes('s'));

console.log(clsssesWith_s);