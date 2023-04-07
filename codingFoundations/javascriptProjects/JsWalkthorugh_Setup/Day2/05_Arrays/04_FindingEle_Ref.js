// Finding Elements using Reference Types
//? https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/find

const characters = [
    {id: 1 , characterName :"bill bob"},
    {id: 2 , characterName :"susan luchi"},
 ]

 //? see if a character has the name 'susan luchi' in their name

 var foundChar = characters.find(function(e){
    return e.characterName === 'susan luchi';
 });

 console.log(foundChar);

  //? see if a character has the letter 'i' in their name

  var foundChar2 = characters.find(function(e){
    return e.characterName.includes('i')
 });

 console.log(foundChar2);