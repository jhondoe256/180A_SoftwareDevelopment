//Break and Continue => keywords change the loops behavior

let i=0;

console.log('Break keyword below.');

while (i<10) {
    if(i===3){
        break; // Lets get out of here!
    }
    console.log(i);
    i++;
}

console.log('Continue keyword below.');

let j=0;

while(j<=10){
    if(j===3){
        console.log(`We hit the third value ${j}`);
        j++;
        continue;
    }
    console.log(j);
    j++;
}