var books = document.getElementById("validationBooks");
var booksInp = document.getElementById("booksInput");
var bookBtn = document.getElementById("booksButton");

var booksData   = document.getElementById("books-data");
var bookName    = document.getElementById("book-name");
var bookPrice   = document.getElementById("book-price");
var authorName  = document.getElementById("author-name");
var authorEmail = document.getElementById("author-email");
var submitBook  = document.getElementById("submit-book");
var label2 = document.getElementById("label2");
var tableDiv = document.getElementById("books-table-data");
var booksTable = document.getElementById("table-body");
var bookCnt = 0;
function AuthorData(a,e){
    this.authorName = a;
    this.authorEmail = e;
}
function Book(n,p,AuthorData){
    this.name = n;
    this.price = p;
    this.AuthorData = AuthorData; 
}

var libraryBooks = [];

function validOrNot(num){
    return num==1?"is-valid":"is-invalid";
}
function checkBookData(){
return bookName.classList.contains("is-valid") && bookPrice.classList.contains("is-valid")
&&authorName.classList.contains("is-valid")&&authorEmail.classList.contains("is-valid");
}

function resetInputs(input){
    input.value = ""; 
}

function showBooks(){
    console.log(booksTable);
    booksTable.innerHTML="";

    libraryBooks.forEach((book, index) => {
        const row = document.createElement('tr');
        row.innerHTML = `
          <th scope="row">${index + 1}</th>
          <td  class="editable" data-field="name">${book.name}</td>
          <td  class="editable" data-field="price">${book.price}</td>
          <td  class="editable" data-field="aname">${book.AuthorData.authorName}</td>
          <td  class="editable" data-field="amail">${book.AuthorData.authorEmail}</td>
          <td><button class="btn btn-md btn-primary edit-btn" data-id="${index}">Edit</button>
          <button hidden class="btn btn-md btn-primary save-btn" data-id="${index}">Save</button>
          </td>
          <td><button class="btn btn-md btn-danger delete-btn" data-id="${index}">Delete</button>
            <button hidden class="btn btn-md btn-danger cancel-btn" data-id="${index}">Cancel</button> 
          </td>`;
        
        booksTable.appendChild(row);
      });
}

// Books number check
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
    bookCnt = books.value;
    booksData.hidden = false;

})



//Checking books data

bookName.addEventListener("input",function(){
    var value = bookName.value;
    if( value.length>= 3) {
       
        bookName.classList.replace(validOrNot(0),validOrNot(1));
        if(checkBookData()) 
            label2.hidden = true;
    }
    else{
        
        bookName.classList.replace(validOrNot(1),validOrNot(0));
        label2.hidden = false;

    }
})

bookPrice.addEventListener("input",function(){
    var value = bookPrice.value;    
    if( value > 0) {    
            bookPrice.classList.replace(validOrNot(0),validOrNot(1));        
            if(checkBookData()) 
                label2.hidden = true;
        }
        else{
            
            bookPrice.classList.replace(validOrNot(1),validOrNot(0));
            label2.hidden = false;
    }

})


authorName.addEventListener("input",function(){
    var value = authorName.value;
    if( value.length> 3) {
       
        authorName.classList.replace(validOrNot(0),validOrNot(1));
        if(checkBookData()) 
            label2.hidden = true;
    }
    else{
        
        authorName.classList.replace(validOrNot(1),validOrNot(0));
        label2.hidden = false;
    }
})

authorEmail.addEventListener("input",function(){
    var value = authorEmail.value;
    if( value.length> 3) {
       
        authorEmail.classList.replace(validOrNot(0),validOrNot(1));
        if(checkBookData()) 
            label2.hidden = true;
    }
    else{
        
        authorEmail.classList.replace(validOrNot(1),validOrNot(0));
        label2.hidden = false;
    }

})


// Adding Book to database
submitBook.addEventListener("click",function(){
   
  if(checkBookData()){
      var author = new AuthorData(authorName.value,authorEmail.value)
      var book = new Book(bookName.value,bookPrice.value,author);
      console.log(book);
      console.log(author);
      libraryBooks.push(book);
      console.log(libraryBooks);
      resetInputs(bookName)   
      resetInputs(bookPrice);  
      resetInputs(authorName); 
      resetInputs(authorEmail);
      bookCnt--;
      if(bookCnt == 0)  {
        booksData.hidden = true;
        tableDiv.hidden = false;
        showBooks();
      }
  }
  else{
    
  }

})



document.addEventListener('click', function(e) {
    // Delete button handling
    if (e.target.classList.contains('delete-btn')) {
        const bookIndex = e.target.getAttribute('data-id');
        libraryBooks.splice(bookIndex, 1);
        showBooks();
    }
    
    // Edit button handling
    if (e.target.classList.contains('edit-btn')) {
        const row = e.target.closest('tr');
        
        const cells = row.querySelectorAll('.editable');
        cells.forEach(
           cell=>{
            cell.contentEditable = true;
            cell.classList.add('editing');
           } 
        );        
        row.querySelector('.edit-btn').hidden = true;
        row.querySelector('.delete-btn').hidden = true;
        row.querySelector('.save-btn').hidden = false;
        row.querySelector('.cancel-btn').hidden = false;
    }

    if (e.target.classList.contains('cancel-btn')) {
        showBooks();    }

    if (e.target.classList.contains('save-btn')) {
        const row = e.target.closest('tr');
        const bookIndex = e.target.getAttribute('data-id');

        // ${book.name}</td>
        // >${book.price}</td>
        // >${book.AuthorData.authorName}</td
        // >${book.AuthorData.authorEmail}</td


        libraryBooks[bookIndex]={
            name: row.querySelector('[data-field="name"]').textContent,
            price: parseFloat(row.querySelector('[data-field="price"]').textContent),
            AuthorData: {
            authorName: row.querySelector('[data-field="aname"]').textContent,
            authorEmail: row.querySelector('[data-field="amail"]').textContent
        }}
        showBooks();
    }

});



// ("Harry Potter", 20.99, {"J.K. Rowling", "jkrowling@example.com"});
