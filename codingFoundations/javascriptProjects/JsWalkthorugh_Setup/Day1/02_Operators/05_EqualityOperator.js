//Strict Equality (Type and Value have to be the same on both sides)
console.log(2===2);  // type -> number (both)  (true)
console.log(2==='2');  //type-> 2(number) === '2'(string)  (false)
console.log('2'==='2');  //type-> 2(string) === '2'(string)  (true)



//Loose Equality (only check the value NOT the type)
console.log(2==2);    //true
console.log(2=='2');  //true
console.log(true == 1);  //true, b/c behind the scenes we are dealing with a boolean (true/false)
                        // which is 0(false), and 1(true)


