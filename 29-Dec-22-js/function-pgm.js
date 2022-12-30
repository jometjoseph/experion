// greet();

// function greet(){
//     console.log("helloo world");
// }

// greet();

// // passing parameters
// function add(para1, para2) {
//     console.log(para1 + para2);
// }

// add(1, 2);

// returninmg values 
// function add1(x, y){
//     return x + y;
// }

// const res = add1(1, 2);
// console.log(res);

// function convertCasing(value){
//     return value.toUpperCase();
// }

// const res = convertCasing('Helloooo world');
// console.log(res);
// console.log(res.toLowerCase());

// function getFirstChar1(value){
//     return value[0];
// }

// const getFirstChar2 = function(value) {
//     return value[0];
// };

const getFirstChar3 = (value) => {
    return value[0];
};

const getFirstChar = value =>value[0];

// console.log(getFirstChar1('Hellooo'));
// console.log(getFirstChar2('Hellooo'));
console.log(getFirstChar3('Hellooo'));
console.log(getFirstChar('hellooo'));