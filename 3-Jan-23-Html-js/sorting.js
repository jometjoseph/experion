// const array1 = [21, 13, 15, 17, 2, 15];
// console.log('Array elements :');
// console.log(array1);
// const len = array1.length;
// let temp = 0;
// for(let i = 0; i < len; i++){
//     for(let j = 0; j < len - i - 1; j++){
//         if(array1[j] > array1[j + 1]){
//             temp = array1[j];
//             array1[j] = array1[j + 1];
//             array1[j + 1] = temp;
//         }
//     }
// }
// console.log(array1);

const array2 = [21, 13, 15, 17, 2, 15];
console.log('array elements are :');
console.log(array2);
let count = 0;
array2.forEach(elements=>{
    count++;
});
let temp = 0;
for(let i = 0; i < count; i++){
    for(let j = 0; j < count - i - 1; j++){
        if(array2[j] > array2[j + 1]){
            temp = array2[j];
            array2[j] = array2[j + 1];
            array2[j + 1] = temp;
        }
    }
}    
console.log('array after sorting');
console.log(array2);
