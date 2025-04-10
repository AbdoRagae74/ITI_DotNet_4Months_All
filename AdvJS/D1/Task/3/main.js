var books = document.getElementById("validationBooks");
var booksInp = document.getElementById("booksInput");
var bookBtn = document.getElementById("booksButton");

var bookName = document.getElementById("book-name");
var bookPrice = document.getElementById("book-price");
var authorName = document.getElementById("author-name");
var authorEmail = document.getElementById("author-email");
var submitBook = document.getElementById("submit-book");
var label2 = document.getElementById("label2");

function validOrNot(num){
    return num==1?"is-valid":"is-invalid";
}


books.addEventListener("input",function(){
    var num = books.value;
    if(num>0) {
        books.classList.replace(validOrNot(0),validOrNot(1));
        bookBtn.disabled=false;
    }
    else{
        books.classList.replace(validOrNot(1),validOrNot(0));
        bookBtn.disabled=true;
    }
    // console.log(num);
})

bookBtn.addEventListener("click",function(){
    booksInp.hidden=true;
})

bookName.addEventListener("input",function(){
    var value = bookName.value;
    console.log(bookName,this.classList);
    if( value.length>= 3) {
       
        bookName.classList.replace(validOrNot(0),validOrNot(1));
        // bookBtn.disabled=false;
    }
    else{
       
            bookName.classList.replace(validOrNot(1),validOrNot(0));
        // bookBtn.disabled=true;
    }
    console.log(value);
})

bookPrice.addEventListener("input",function(){
    var value = bookPrice.value;    
    if( value > 0) {    
        console.log();    
            bookPrice.classList.replace(validOrNot(0),validOrNot(1));        
    }
    else{

            bookPrice.classList.replace(validOrNot(1),validOrNot(0));
    }
    console.log(value);
})


authorName.addEventListener("input",function(){
    var value = authorName.value;
    if( value.length> 3) {
       
        authorName.classList.replace(validOrNot(0),validOrNot(1));
    }
    else{
       
        authorName.classList.replace(validOrNot(1),validOrNot(0));
    }
    console.log(value);
})

authorEmail.addEventListener("input",function(){
    var value = authorEmail.value;
    if( value.length> 3) {
       
        authorEmail.classList.replace(validOrNot(0),validOrNot(1));
    }
    else{
       
        authorEmail.classList.replace(validOrNot(1),validOrNot(0));
    }
    console.log(value);
})

submitBook.addEventListener("click",function(){
   console.log(bookName.classList.contains("is-valid"));
    if(bookName.classList.contains("is-valid") && bookPrice.classList.contains("is-valid")
    &&authorName.classList.contains("is-valid")&&authorEmail.classList.contains("is-valid"))
{label2.hidden = false; }
else 
label2.hidden=true;

})