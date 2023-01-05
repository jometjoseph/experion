const array1 = ['Jack', 'Jones', 'Matt', 'Tom', 'Henry', 'Chris', 'Tony'];
console.log(array1);
const searchTerm = 'Tom';
for (let i = 0; i < array1.length; i++){
    if (searchTerm == array1[i]){
        console.log(searchTerm,'is available in the array in ',i+1,'th location');
    }
}
