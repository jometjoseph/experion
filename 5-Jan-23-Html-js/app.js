function handleClick(e){
    e.preventDefault();
   // console.log('handle clicked');
    console.log(e);
    const email = document.forms['login']['email'];
    // aleternate method
    // const email1 = document.forms.login.email.value;
    const password = document.forms.login.password;
    const age = document.forms.login.age;

    const emailValue = email.value;
    const passwordValue = password.value;
    const ageValue = age.value;

    const passwordErrorMsg = password.nextElementSibling;
    const ageErrorMsg = age.nextElementSibling;
    // console.log(email);
    // console.log(password);
    if(passwordValue.length < 6){
        password.style.border = '1px solid red';
        passwordErrorMsg.classList.remove('d-none');
        passwordErrorMsg.innerHTML += '<li>Password must be at least 6 characters</li>';
    }
    if(passwordValue.includes(' ')){
        password.style.border = '1px solid red';
        passwordErrorMsg.classList.remove('d-none');
        passwordErrorMsg.innerHTML += '<li>Password must not contain spaces</li>';
    }
    if(ageValue < 18 || ageValue > 100){
        age.style.border = '1px solid red';
        ageErrorMsg.classList.remove('d-none');
        ageErrorMsg.innerHTML = '<li>Invalid age</li>'; 
    }
    

}