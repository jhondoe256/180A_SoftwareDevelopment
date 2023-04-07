// An Array is a collection
// Adding to an Array

const values = [8,7,6,5,4];

console.log(values);

//? add to the beginning

values.unshift(0,1,2,3);

console.log(values);

//? I want to go to a specific index or position
values.splice(2,0,'terry','brown');
console.log(values);

//? add to the end of the Array
values.push(2,3);
console.log(values);