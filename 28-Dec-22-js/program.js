// console.log('Hello World');
// console.log('Hello', 'World');
// console.clear();

// var i = 5;
// console.log(i);
// var firstName = 'John';
// var lastName = 'Doe';
// console.log(firstName, lastName);
// console.log(typeof firstName);

// var data = 'This is a string';
// console.log(data[1]);
// console.log(data.length);
// console.log(data[data.length - 1]);

// var res = data.toUpperCase();
// data = data.toUpperCase();   //string is immutable.So replace original string.
// console.log(res);

// trim() removes leading and trial white spaces.
// var message = '     Js for web        ';
// console.log(message);
// console.log(message.trim());  
// console.log(message.trimEnd());

// var message = 'Js for web';
// console.log(message.split(' '));
// var res = message.replace(' ','_');
// var res = message.replaceAll(' ','_');
// console.log(res);

// var message1 = '   Js for web   ';
// var res1 = message1.toUpperCase().trim().replaceAll(' ','_');
// console.log(res1);

for(let i = 0; i < 5; i++){
    console.log('Inside for loop: ', i);
}
// console.log('outside for loop', i);      //Error- outside scope

// const--declare all the unchangeable values as const
// const firstName = 'john';
// const lastName = 'Doe';
// console.log(firstName, lastName);

// const language = 'JS';
// console.log(language);

// const numone = 5;
// const num2 = 7;
// const res = numone + num2;
// console.log(res);

// const n1 = 7;
// const n2 = 8;
// const res1 = n1+ "+" +n2+ "=" +(n1+n2);
// const res2 = `${n1} + ${n2} = ${n1+n2}`;
// console.log(res1);
// console.log(res2);

var firstString = 'Java';
var lastString = 'Script';

var res1 = firstString + ' ' + lastString;
var res2 = firstString.concat(' ',lastString);
var res3 = `${firstString} + ${lastString}`;

console.log(res1);
console.log(res2);
console.log(res3);

