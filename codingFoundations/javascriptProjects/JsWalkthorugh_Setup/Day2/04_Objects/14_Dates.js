//Date object 

//? https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date

const firstDate = new Date();
const secondDate = new Date('July 4 2023 08:00AM');
const thirdDate = new Date(2023,5,22,5,0);

firstDate.setFullYear(2030);

console.log(firstDate.toDateString());
console.log(firstDate.toTimeString());
console.log(firstDate.toISOString());  // for back-end use