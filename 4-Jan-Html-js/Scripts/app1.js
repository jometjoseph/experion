// function doThisRunningTask(callback){
//     setTimeout(() => {
//         const name = 'Javascript';
//         callback(name);
//     }, 5000);
// }

// function showResult(res){
//     console.log(res);
// }
// doThisRunningTask(showResult);
// console.log('I am done');
/* {<script>
        const http = new XMLHttpRequest();
        http.onreadystatechange = function(){
            if(this.readyState == 4 && this.status == 200){
                console.log(this.responseText);
            }
        }
        http.open('GET', 'http://reqres.in/api/users/2');
        http.send();
        console.log('completed');

    

    </script>} */

// const p = new Promise((resolve, reject) => {
//     // some asynch work
//     const name1 = 'javascript 2';
//     resolve(name1);
// });
// p.then(res => console.log(res));


