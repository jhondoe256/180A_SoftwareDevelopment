// Strings in Js

//? https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String

//todo: the string primative:
const message ="   dude, what's up?  ";

//todo: string object:
const anotherMessage = new String('hi dude');

console.log(typeof message);  //string
console.log(typeof anotherMessage);  //object

//? how can we get the count of characters w/n a stirng
console.log(message.length); //21


//? what if we wanted a specific character
console.log(message[7]);

//? see if a string contains a specific word
console.log(message.includes("dude"));
console.log(message.includes("Dude"));

//? see if string ends with a value
console.log(message.endsWith("?"));
console.log(message.endsWith(" "));

//? see if string starts with a value
console.log(message.startsWith("dude"));
console.log(message.startsWith(" "));

//? a particular index of a string, based on a value
console.log(message.indexOf("u"));

//? replacing a string value
console.log(message.replace("what's",'you should go'));


//? make everything uppercase
console.log(message.toUpperCase());


//? make everything lowercase
console.log(message.toLowerCase());

//? trim the white space
console.log(message.trim());


//todo: escape keys
const messageEscString = 'dude , what\'s up?';
console.log(messageEscString);

// \n new line
const messageBackSlashN = 'dude, \nwhat\'s up?'
console.log(messageBackSlashN);

const messageSplit = message.split(' ');
console.log(messageSplit);