//logical operator -> make decisions based on multiple conditions

//* 1. Logical 'and' (&&)
//* return true if 'both' operands are true
console.log(true && true); //both are true (true)
console.log(true && false); //both are not true (false)

/**
 * Example: what if Mario gets 'Mushroom-powerup', we only want mario to 'Grow big'
 * if he's small AND (&&) comes in contact with the 'Mushroom-powerup'
 */

let player = "Mario";
let hasMadeContact = true;
let isSmall = true;

let hasPowerUp =
  isSmall === true && hasMadeContact === true
    ? `${player} has activated the Mushroom-Powerup!`
    : `${player} can not activate the Mushroom-Powerup!`;

console.log(hasPowerUp);

//* 2 logical 'or' (||)
//* Returns true if one of the operands are true
console.log(true || false); //true
console.log(false || true); //true
console.log(true || true); //true
console.log(false || false); //false

/*
    we want to 'kill' an enemy, but you have to jump on his head, 
    or hit em' with a fire ball
*/

let hasStompedOnEnemyHead = false;
let hasUsedFlowerPower = true;

let enemyDead =
  hasStompedOnEnemyHead || hasUsedFlowerPower
    ? "Enemy Dead"
    : `${player} lost a life`;
console.log(enemyDead);

//*3 Not (!) bang operator -> sets whatever is 'true' to FALSE. and whatever is 'false' to TRUE.
//* THIS ONLY HAPPENS WHEN THE ! operator is IN FRONT OF THE VARIABLE
//   !hasUsedFlowerPower  (line 38, is true, but now its false)
/*
 *  we want the player to hit the continue button, then gameOver is set to false;
 */

let gameOver = true;
let hasPressedContinue = true;

// we are at the gameover screen
             // no press (is not true)   then gO is true  :   gO is false 
let restartGame = !hasPressedContinue ? (gameOver = true) : (gameOver = false);

let finalResult = (restartGame)? "Game Over, Please try again later" : "Restarting Game!";

console.log(finalResult);
