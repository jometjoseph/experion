const array1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
const array2 = [];
for (let i = 0; i < array1.length; i++){
    if (array1[i] % 2 == 0){
        array2.push(array1[i]);
    }
}
console.log(array2);

// alternate methods
const numbers = [1, 2, 3, 4, 5, 6];
function isEven (value) {
    return value % 2 == 0;
}

const res = numbers.filter(isEven);
console.log(res);