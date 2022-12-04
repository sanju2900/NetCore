let parent = document.getElementById('dom-1');
let spans = parent.getElementsByTagName(span);

let boyElements = document.getElementsByClassName("byname");
let girlElements = document.getElementsByClassName("get");

let t = document.querySelector("span, p");
t; // <p> </p> --> `p` element is above `span`

e = document.querySelector("span, code");
e; // <span>sp</span> --> because code element is not available 
let e = document.querySelectorAll("span, p");
// [p, span]