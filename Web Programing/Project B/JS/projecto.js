var pw1 = document.getElementById("pswd");
var pw2 = document.getElementById("pswd2");
var letter = document.getElementById("letter");
var capital = document.getElementById("capital");
var number = document.getElementById("number");
var length = document.getElementById("length");

pw1.onfocus = function() {
  document.getElementById("message").style.display = "block";
}

pw1.onblur = function() {
  document.getElementById("message").style.display = "none";
}

pw1.onkeyup = function() {

   var lowerCaseLetters = /[a-z]/g;
      if(pw1.value.match(lowerCaseLetters)) {
         letter.classList.remove("invalid");
         letter.classList.add("valid");
      } else {
         letter.classList.remove("valid");
         letter.classList.add("invalid");
      }

      var numbers = /[0-9]/g;
      if(pw1.value.match(numbers)) {
         number.classList.remove("invalid");
         number.classList.add("valid");
      } else {
         number.classList.remove("valid");
         number.classList.add("invalid");
      }

 if(pw1.value.length >= 8 && pw1.value.length <= 15) {
         length.classList.remove("invalid");
         length.classList.add("valid");
      } else {
         length.classList.remove("valid");
         length.classList.add("invalid");
      }

      if(pw1 == pw2)  
      {   
         igual.classList.remove("invalid");
         igual.classList.add("valid");
      } else {
         igual.classList.remove("valid");
         igual.classList.add("invalid");
      }
}