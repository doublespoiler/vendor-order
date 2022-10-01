function myClock() {         
  setTimeout(function() {   
    const d = new Date();
    const n = d.toDateString() + " " + d.toLocaleTimeString();
    document.getElementById("clock").innerHTML = n; 
    myClock();             
  }, 1000)
}

function randomBg(){
  const images = ['../images/bread1.jpg', '../images/bread2.jpg', '../images/bread3.jpg', '../images/bread4.jpg'];
  const body = document.getElementById("bodycontent");
  body.style.backgroundImage = 'url(' + images[Math.floor(Math.random() * images.length)] + ')';
}

 
window.addEventListener("DOMContentLoaded", myClock());
window.addEventListener("DOMContentLoaded", randomBg());