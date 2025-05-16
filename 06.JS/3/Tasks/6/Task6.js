const library = {
    books:[
        {
            title:"Hello world",
            author:"John doe",
            year:2023 
        },
        {
            title:"1984",
            author:"George Orwell",
            year:1949 
        },
        {
            title:"The Great Gatsby",
            author:"F. Scott Fitzgerald",
            year:1925 
        },
        {
            title:"Hello world",
            author:"Alex",
            year:2023 
        }
    ]
};

function logsBookTitle(library){
    for(var book of library.books){
        document.writeln(`${book.title}<br>`)
        console.log(book.title);
    }
}

logsBookTitle(library);

