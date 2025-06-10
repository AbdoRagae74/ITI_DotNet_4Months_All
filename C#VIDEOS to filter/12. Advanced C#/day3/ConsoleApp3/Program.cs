namespace ConsoleApp3
{
    public delegate string del1(Book b);
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get;
            set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title; 
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }
        public override string ToString()
        {
            
            return $"ISBN: {ISBN}, Title: {Title}, Authors: {getAuthors()} Publish Date: {PublicationDate.ToShortDateString()}, Price: {Price}";
        }
        public string getAuthors()
        {
            string authors = "";
            foreach (var item in Authors)
            {
                authors += item + ", ";
            }
            return authors;
        }
    }
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            return B.getAuthors();
        }
        public static string GetPrice(Book B)
        {
            return $"{B.Price}";
        }
    }
    public class LibraryEngine
    {

        public static void ProcessBooks(Book[] bList, del1 _delegate)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(_delegate(B));
            }
        }

        //public static void ProcessBooks(Book[] bList, Func<Book, string> _delegate)
        //{
        //    foreach (Book B in bList)
        //    {
        //        Console.WriteLine(_delegate(B));
        //    }
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new ("abc03", "head first", ["a1", "a2", "a3"], new DateTime(2010,6,24), 1200);
            //Console.WriteLine(b1);
            Book b2 = new("abc12", "introduction to abc", ["b1", "b2", "b3"], new DateTime(2001, 9, 4), 430);
            Book b3 = new("abc27", "novel of xyz", ["c1", "c2", "c3"], new DateTime(2024, 1, 14), 135);
            Book[] booksArray = { b1, b2, b3 };


            //------------ get title of each book in the array -------------

            Console.WriteLine("getting all titles... [using my defined delegate]");
            del1 getTitles = new del1(BookFunctions.GetTitle);
            LibraryEngine.ProcessBooks(booksArray, getTitles);


            //Console.WriteLine(d.Invoke(b1)+" successful invoking");

            Console.WriteLine("getting all authors... [using Action (built) in delegate]");
            Func<Book, string> getAuthors = BookFunctions.GetAuthors;
            //LibraryEngine.ProcessBooks(booksArray, getAuthors);


            Console.WriteLine("getting all prices... [using lambda expression stored in a delegate]");

            //Func<Book, string> getPrices = () => "sd";

            LibraryEngine.ProcessBooks(booksArray, delegate (Book b) { return b1.ISBN; }); // normal anonymous function using delegate keyword
            LibraryEngine.ProcessBooks(booksArray,   b =>  b1.ISBN ); // labmda expression (syntax sugar of an anonymous function)

        }
    }
}
