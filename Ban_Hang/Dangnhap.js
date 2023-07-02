// Signup
// validation form register and register user local storage


function signup(e)

{
    event.preventDefault();
    var fullname=document.getElementById("fullname").value;
    var gmail=document.getElementById("gmail").value;
    var password=document.getElementById("password").value;
    
    var user= 
{
    Fullname : fullname,
    Gmail : gmail,
    Password : password
}
var json =JSON.stringify(user);
localStorage.setItem(fullname,json);
alert("dang ky thanh cong")
    
}