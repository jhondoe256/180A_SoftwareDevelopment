//Arrow functions

const characters = [
    {id: 1 , characterName :"bill bob"},
    {id: 2 , characterName :"susan luchi"},
 ]

 var foundChar = characters.find((e)=> e.characterName === 'susan luchi');

 console.log(foundChar);
