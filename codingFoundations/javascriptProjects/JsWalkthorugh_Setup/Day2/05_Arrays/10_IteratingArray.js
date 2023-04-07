// looping through an Array

const students = ['Tim','Jessy','Cat'];

students.forEach((function(student){
    console.log(student);
}));


//the 1 LINER approach:
students.forEach( (student,index) => console.log(student,index));