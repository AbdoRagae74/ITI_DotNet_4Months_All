function Book(t,nCh,au,nP,pub,nC){
    this.title = t;
    this.numberOfChapters = nCh;
    this.author = au;
    this.numberOfPages = nP;
    this.publisher = pub;
    this.numberOfCopies = nC;
}


function Box(w,h,l,m){
    this.height = h;
    this.width = w;
    this.length = l;
    this.material = m;
    this.volume = w*h*l;
    this.content=[];
}

Box.prototype.numberOfBooks = function(){
    return this.content.length;
}

Box.prototype.deleteBooks = function(id){

    for(var i = this.content.length-1 ; i>=0;i--){
        if(this.content[i].author==id || this.content[i].title==id )
            this.content.splice(i,1);
    }
    
}
Box.prototype.addBook = function(book){
    if(book.constructor ==Book)
    this.content.push(book);

} 

Box.prototype.toString = function(){
    console.log(`width = ${this.width}`);
    console.log(`height = ${this.height}`);
    console.log(`volume = ${this.volume}`);
    console.log(`Number of Books = ${this.content.length}`);
}
Box.prototype.valueOf = function(){
    return this.content.length;
}

    book1 = new Book("HTML", 12, "John Doe", 300, "TechPub", 1);
    book2 = new Book("CSS", 8, "Alice Abc", 250, "WebPress", 1);
    book3 = new Book("C#", 10, "Bob smiler", 400, "TechPub", 2);
    box1 = new Box(10, 20, 30, "Cardboard");
    box2 = new Box(15, 15, 15, "Plastic");
    box1.addBook(book1);
    box1.addBook(book2);
    box2.addBook(book3);

    box1.toString();
    box1.deleteBooks("Alice Abc"); // Delete
    console.log(box1+box2);//ValueOf

