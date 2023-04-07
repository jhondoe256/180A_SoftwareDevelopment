//Object -> using OOP (OBJECT ORIENTED PROGRAMMING)
         // Objs working together to perform tasks

let firstName = 'Super';
let lastName = 'Mario';
let address= '123 1up Lane'

//* object literal setup
//* composed of key/value pairs
let player = {
    firstName:"Super",
    lastName: "Mario",
    address : '123 1up Lane'
}

//loging the entire 'player' obj
console.log(player);

//todo: make modifications:

player.firstName = "Dude?"

//loging the player firstName
console.log(player.firstName);

//loging the entire 'player' obj
console.log(player);

//todo: use backet notation
player["address"] = "aw, you lost a life.";
console.log(player["address"]);

//loging the entire 'player' obj
console.log(player);