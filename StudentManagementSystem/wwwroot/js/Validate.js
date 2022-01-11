function Validate(fname, lname, email, password, confirm, phone) {
    if (fname === null || fname === "") {
        return "first name cannot be empty";
    } else if (lname === null || lname === "") {
        return "last name cannot be empty";
    } else if (email === null || email === "") {
        return "email cannot be empty";
    } else if (password === null || password === "") {
        return "password cannot be empty";
    } else if (confirm === null || confirm === "") {
        return "confirm password cannot be empty";
    } else if (phone === null || phone === "") {
        return "phone cannot be empty";
    } else {
        return "allset";
    }
}