using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day03Adv_C_.Program;

namespace Day03Adv_C_
{

    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string _ISBN, string _Title,
        string[] _Authors, DateTime _PublicationDate,
        decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }
        public override string ToString()
        {
            string bookAuthors = "";
            foreach (var a in Authors) { bookAuthors += a + "\n"; }

            return $"ISBN: {ISBN}\nTitle : {Title}\nAuthors : {bookAuthors}price : {Price}\nPublication date : {PublicationDate.ToShortDateString()} ";
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
            string bookAuthors = "";
            foreach (var a in B.Authors)
                bookAuthors += a + "\n";

            return bookAuthors;
        }
        public static string GetPrice(Book B)
        {
            return (B.Price).ToString();
        }
    }
    public class LibraryEngine
    {
        public static void ProcessBooks(Book[] bList, Func<Book, string> funcExample, int a)
        {

            foreach (Book B in bList)
            {
                Console.WriteLine(funcExample(B));
            }
        }

        public static void ProcessBooks(Book[] bList, fPtr mydel)
        {

            foreach (Book B in bList)
            {
                Console.WriteLine(mydel(B));
            }
        }
    }
}
