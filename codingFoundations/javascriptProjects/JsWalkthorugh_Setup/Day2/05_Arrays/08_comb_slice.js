// Combining and Slicing Arrays

const students = ['Tim','Jessy','Cat'];

const classes= ['Math','Science','PhysEd'];


//combine them

var student_classes = students.concat(classes);
console.log(student_classes);


//use slice,its the opposite of concat
var slicedValues = student_classes.slice(2,4);
console.log(slicedValues);

var slicedValues2 = student_classes.slice(2);
console.log(slicedValues2);
