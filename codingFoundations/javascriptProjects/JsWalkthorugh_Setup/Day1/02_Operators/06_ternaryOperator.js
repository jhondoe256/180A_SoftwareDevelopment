//Tenerary Operator

//logic: character, and when it collects 100 coins we want to play the special theme music
// otherwise just play the regular background music?

let coins=100;

let music = (coins >=100)? "Playing Special-Theme-Music" : "Playing Regular-Background-Music" ;

console.log(music);