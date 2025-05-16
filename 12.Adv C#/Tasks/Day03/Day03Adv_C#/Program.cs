namespace Day03Adv_C_
{
    public delegate string fPtr(Book b);

    internal class Program
    {






        static void Main(string[] args)
        {
            DateTime d = new DateTime(1997, 03, 28);
            string[] authors = { "J.K.Rowlling", "Autohr2" ,"Author3" };
            Book b1 = new Book("31235", "Harry Potter", authors,d,1200 ); 
            Book[] booksarr = new Book[] { b1 };
            //User Defined Delegate  delegate
            fPtr myDel = BookFunctions.GetAuthors;
            Console.WriteLine("Using Func");
            LibraryEngine.ProcessBooks(booksarr, BookFunctions.GetTitle,1);
            Console.WriteLine();
            Console.WriteLine("Using user defined delegate");
            LibraryEngine.ProcessBooks(booksarr, myDel);
            Console.WriteLine();
            Console.WriteLine("sending delegate as parameter");
            LibraryEngine.ProcessBooks(booksarr, delegate (Book book) { return(BookFunctions.GetAuthors(book)); });

            Console.WriteLine("Lambda expression");
            LibraryEngine.ProcessBooks(booksarr,  (Book book) => { return(BookFunctions.GetAuthors(book)); });
            Console.WriteLine("Lambda expression one line statement");
            LibraryEngine.ProcessBooks(booksarr,  book =>  (BookFunctions.GetAuthors(book)));


        }
    }
}
