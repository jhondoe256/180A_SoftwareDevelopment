//todo: we are using codeRunner......


/*
 * 
    ? The old way: (hoisting)
    var someVariable = 'ted';  alt + up_arrow_key
    someVariable=3000;
 */

// now we use 'let' or 'const' to 'setup' our variable

//? Declaration 
//? by default variables in Js are 'undefined'
//* This variable hasn't been assigned a value
let myName;

//what value can I get
console.log(myName);

//? we are assigning the value 'Terry' to myName
// '=' is the assignment operator 
myName = 'Terry';
console.log(myName);

//TODO RULES
//todo: 1. Cannot use a reserved keyword  'let' 'const' etc..
//todo: 2. NAME must have Meaning (purpose)  
//todo: 3. Cannot start with a number  (33tim), dont do this
//! let 33tim
//todo: 4. Cannot contain space or hyphen (-) , DONT DO THIS  (my-name)
//! let my-Name;
//todo: 5. Vaiables are 'case sensitive'
let MYNAME = 'smooth';
console.log('--- Different values ---');
console.log(MYNAME);
console.log(myName);

//* casing:
//camelCasing -> fist letter is lower cased all perceeding first letters are capitalized.
//   let thisIsHowAReallyLongOneLooks

//snakeCasing -> all lowercase 
//  let this_is_snake_casing