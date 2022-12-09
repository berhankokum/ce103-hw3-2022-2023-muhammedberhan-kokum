using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;

namespace ce103_hw3__library_lib
{
    public class Books
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int Pages { get; set; }
        public int Year { get; set; }
        public int Edition { get; set; }
        public string Editors { get; set; }
        public string Publisher { get; set; }
        public string City { get; set; }
        public double Price { get; set; }
        public string AuthorKeywords { get; set; }
        public string Tags { get; set; }
        public string Abstract { get; set; }
        public string URL { get; set; }
        public int DOI { get; set; }
        public int ISBN { get; set; }
        public int Rack { get; set; }
        public int Row { get; set; }
    }
    public class BookList
    {
        public string _text { get; set; }
        public void bookList()
        {
            Console.Clear();
            int file_name;
            string file_location = @" C:\LibrarySystem\Book list\Books.dat";
            _text = System.IO.File.ReadAllText(file_location);
            Console.Write(_text);

        }
    }
    public class SearchBook
    {
        public string _book_id { get; set; }
        public string _file_location { get; set; }
        public void Searchbook()
        {
            string location = _file_location;
            string bookid = _book_id;


            FileStream fl = new FileStream(location, FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(fl);
            string text = read.ReadLine();

            while (text != null)
            {
                Console.WriteLine(text);
                text = read.ReadLine();
            }
            read.Close();
            fl.Close();
        }

    }
    public class Categories
    {

        public string AddCategory { get; set; }
        public string Del { get; set; }
        public void category()
        {

            Directory.Delete(@"C:\LibrarySystem\Categories\" + "\\" + Del, true);
        }
        public void addcategory()
        {
            Directory.CreateDirectory(@"C:\LibrarySystem\Categories\" + "\\" + AddCategory);
        }
    }

    public class BookDelete
    {
        public string _book_delete { get; set; }
        public void bookDelete()
        {
            File.Delete(@"C:\LibrarySystem\Books" + "\\" + _book_delete + ".dat");
        }

    }
    public class BookStatus
    {
        public int _status { get; set; }
        public void borrowed()
        {
            File.Move(@"C:\LibrarySystem\Book Status\Borrowed" + "\\" + _status + ".dat", @"C:\LibrarySystem\Book Status\Returned" + "\\" + _status + ".dat");
        }
        public void returned()
        {
            File.Move(@"C:\LibrarySystem\Book Status\Returned" + "\\" + _status + ".dat", @"C:\LibrarySystem\Book Status\Borrowed" + "\\" + _status + ".dat");
        }
    }


}

