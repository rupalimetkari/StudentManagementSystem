function ValidateRegister(fname, lname, email, password, confirm, phone, ddl) {
    var regemail = /\S+@\S+\.\S+/;
    var regphone = /^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$/;
    if (fname === null || fname === "") {
        return "first name cannot be empty";
    } else if (lname === null || lname === "") {
        return "last name cannot be empty";
    } else if (phone === null || phone === "") {
        return "phone cannot be empty";
    } else if (regphone.test(phone) === false) {
        return "phone number is not in proper format";
    } else if (ddl === 0) {
        return "select a user type";
    }else if (email === null || email === "") {
        return "email cannot be empty";
    } else if (regemail.test(email) === false) {
        return "email address is not in proper format";
    } else if (password === null || password === "") {
        return "password cannot be empty";
    } else if (password.length < 6) {
        return "password length should be minimum 6 character"
    } else if (confirm === null || confirm === "") {
        return "confirm password cannot be empty";
    } else if (confirm.length < 6) {
        return "confirm password length should be minimum 6 character"
    } else {
        return "allset";
    }
}

function ValidateLogin(email, ddl, password) {
    var regemail = /\S+@\S+\.\S+/;
    if (ddl === 0) {
        return "select a user type";
    } else if (email === null || email === "") {
        return "email cannot be empty";
    } else if (regemail.test(email) === false) {
        return "email address is not in proper format";
    } else if (password === null || password === "") {
        return "password cannot be empty";
    } else {
        return "allset";
    }
}

function ValidatePassword(password, confirm) {
    if (password === null || password === "") {
        return "password cannot be empty";
    } else if (password.length < 6) {
        return "password length should be minimum 6 character"
    } else if (confirm === null || confirm === "") {
        return "confirm password cannot be empty";
    } else if (confirm.length < 6) {
        return "confirm password length should be minimum 6 character"
    } else {
        return "allset";
    }
}

function ValidateProfileUpdate(fname,lname,phone) {
    var regphone = /^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$/;
    if (fname === null || fname === "") {
        return "first name cannot be empty";
    } else if (lname === null || lname === "") {
        return "last name cannot be empty";
    } else if (phone === null || phone === "") {
        return "phone cannot be empty";
    } else if (regphone.test(phone) === false) {
        return "phone number is not in proper format";
    }
    else {
        return "allset";
    }
}

