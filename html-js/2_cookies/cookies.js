// COOKIES

//Add cookies
document.cookie ="name=Raj; ";
document.cookie ="item=bread; ";

//set cookies remove time
document.cookie ="process=delete,cookies; expires=Mon, 05 Dec 2022 04:00:00 UTC";


//Delete cookies =for this set time in past
document.cookie ="item=bread,cookies; expires=Thu, 01 Dec 2022 04:00:00 UTC";


//Read cookies
let x =document.cookie;
//alert(x);//see result in popup
console.log(x);//to see in console

//LOCAL STORAGE

//add local session
//add item
localStorage.setItem('Name','Sanjana');
localStorage.setItem('Item','India ');

//get item on console
console.log(localStorage.getItem('Item'));

//remove item
localStorage.removeItem('Name');


//SESSION STORAGE
sessionStorage.setItem('Firstname','Sanjana');
sessionStorage.setItem('Hello','World');

console.log  (sessionStorage.getItem('Firstname'));

//remove session
sessionStorage.removeItem('Firstname');