//The Map Method -> map each item in an Array to somehing else

const values = [22,-10,12,14];

let positive = values.filter(n=> n >= 0);

//mapping numbers to strings
const li = positive.map(n=> '<li>'+ n + '</li>');

//use 'join' to join the elements into one string
const joinedString = '<ul>'+li.join('') +"</ul>";

// const joinedString = `<ul>\n${li.join('\n')}\n</ul>`;

console.log(li);
console.log(joinedString)

// students.forEach( (student,index) => console.log(student,index));

console.log('== Mapping to other objects ==');

//mapping to an object 
//need to surround {} with parenthesis to get this to work
const objs = positive.map(n=>({value: n}));

console.log(objs);

//this is another way we can do things, by 'chaining' methods together.
const chainedResult = positive
    .filter(n=>n>=0)
    .map(n=>({value: n}))
    .filter(obj=>obj.value > 12)    //get objects with value > 12
    .map(obj=>obj.value)           // then get objcet by their value (literal number)
    .sort();                      // sort them out

console.log(chainedResult);


// have some fun with this.......