//Emptying an Array

let values = [77,8,3,2,5,4];
let another = values;  //this will prevent garbage collection

//1.
//wont work w/ line 4 existing
//values = [];

//2.
//values.length=0;  //this just deletes previous values.


//3. 
//values.splice(0,values.length);


//4.
while (values.length>0) {
    values.pop();
    console.log(values);
    console.log(another);
}

