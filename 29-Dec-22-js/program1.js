// let numbers = [1,2,3,'Four'];
// console.log(typeof numbers);
// console.log(numbers);

// // array updation
// numbers[0] = 100;
// console.log(numbers[0]);

// // push method--use instead of using index for adding elements
// numbers.push(5);
// console.log(numbers);

let firstArray = [1,2,3];
let secondArray = [4,5,6,7];

let thirdArray = firstArray.concat(secondArray);  // returns a new array with modified values
firstArray.push(...secondArray);   // push modifies original array
console.log(firstArray);
console.log(thirdArray);

const firstArray1 = [1,2,3];
firstArray1[0] = 10;
console.log(firstArray1);

