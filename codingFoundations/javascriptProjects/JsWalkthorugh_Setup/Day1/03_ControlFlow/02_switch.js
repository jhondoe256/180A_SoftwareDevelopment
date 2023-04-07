// Switch and case

//todo: print in console what 'Powerup' Mario has made contact with

let powerUp = 'Mushroom';

// take the value of a variable and compare it to other values (case)
// and each case can perfom its own set logic

switch(powerUp){
    case 'Mushroom':
        console.log("Activated mushroom Powerup!!!");
        console.log('Yay its the mushroom!!!!');
    break; //if not then the values will 'fall through'
    case 'Flower-Power':
        console.log("Activated Flower Power!");
    break;
    default:
        console.log("Ah, your just 'small-Mario'.");
}

//* This does the same as the above!
if(powerUp === 'Mushroom'){
    console.log("Activated Mushroom Powerup!!!");
    console.log('Yay its the mushroom!!!!');
}
else if(powerUp==='Flower-Power'){
    console.log("Activated Flower Power!");
}
else{
    console.log("Ah, your just 'small-mario'");
}