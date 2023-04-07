// Joining Arrays

const students = ['Tim','Jessy','Cat'];

const joinedResult = students.join(','); // this takes the array and turns it into a string. seperating items by(,)
console.log(joinedResult);

const myMessage = "This is my message";

//this will return an array that will be crated by the whitespace in the
//above message
const myMessageAsArray = myMessage.split(' '); 

console.log(myMessageAsArray);

//let's combine the above stuff with a "join"

let combinedMessage = myMessageAsArray.join('-');  //Remember this 'returns' a STRING
console.log(combinedMessage);