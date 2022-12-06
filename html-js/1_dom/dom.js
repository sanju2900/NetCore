//single element selector
let ele = document.getElementById('dom-1');
let ele2 = document.getElementById('dom-2');

console.log(ele);
console.log(ele2);
//ele.style.color='red';
//ele.innerText ='hello world';
let ele1 = ele.getElementsByTagName('span');
console.log(ele1);

let sel = document.querySelector('#dom-1');

sel = document.querySelector('.get');
console.log(sel); // <span>sp</span> --> because code element is not available 


///Multi element selector

let Elements = document.getElementsByClassName('get');
let dom2Elements = document.getElementsByClassName('byname');

//let t = document.querySelector("span, p");
//t; // <p> </p> --> `p` element is above `span`
let e = document.querySelectorAll("span, p");
// [p, span]