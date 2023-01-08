function formValidation(e){
    e.preventDefault();
    console.log(e);
    const firstName = document.forms.login.firstName;
    const lastName = document.forms.login.lastName;
    const email = document.forms.login.email;
    const password = document.forms.login.password;
    const confirmPassword = document.forms.login.confirmPassword;

    const fNameValue = firstName.value;
    const lNameValue = lastName.value;
    const emailValue = email.value;
    const passwordValue = password.value;
    const confPasswordValue = confirmPassword.value;

    const fNameErrorMsg = firstName.nextElementSibling;
    const lNameErrorMsg = lastName.nextElementSibling;
    // const lNameErrorMsg = document.getElementById('lastnameMsg');
    const emailErrorMsg = email.nextElementSibling;
    const passwordErrorMsg = password.nextElementSibling;
    const confPasswordErrorMsg = confirmPassword.nextElementSibling;

    // const nameLetters = '/^[a-zA-Z]+ [a-zA-Z]+$/';


    // validation begins
    if(fNameValue.length < 3){
        firstName.style.border = '1px solid red';
        fNameErrorMsg.classList.remove('d-none');
        fNameErrorMsg.innerHTML += '<li>First Should contain a minimum of 3 characters</li>'
    }
    // if(!nameLetters.test(fNameValue)){
    //     firstName.style.border = '1px solid red';
    //     fNameErrorMsg.classList.remove('d-none');
    //     fNameErrorMsg.innerHTML += '<li>First name should contain alphabets only</li>'
    // }
    
    if(lNameValue == ''){
        lastName.style.border = '1px solid red';
        lNameErrorMsg.classList.remove('d-none');
        lNameErrorMsg.innerHTML += '<li>Last Name Should not be empty</li>'
    }
    // if(!nameLetters.test(lNameValue)){
    //     lastName.style.border = '1px solid red';
    //     lNameErrorMsg.classList.remove('d-none');
    //     lNameErrorMsg.innerHTML += '<li>Last name should contain alphabets only</li>'
    // }
    if(emailValue == ''){
        email.style.border = '3px solid red';
        emailErrorMsg.classList.remove('d-none');
        emailErrorMsg.innerHTML += '<li>email is a required field</li>'
    }
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
    if(confPasswordValue == ''){
        confirmPassword.style.border = '1px solid red';
        confPasswordErrorMsg.classList.remove('d-none');
        confPasswordErrorMsg.innerHTML += '<li>You should confirm password</li>';
    }
    if(confPasswordValue != passwordValue){
        confirmPassword.style.border = '1px solid red';
        confPasswordErrorMsg.classList.remove('d-none');
        confPasswordErrorMsg.innerHTML += '<li>Both passwords should match</li>';
    }
}