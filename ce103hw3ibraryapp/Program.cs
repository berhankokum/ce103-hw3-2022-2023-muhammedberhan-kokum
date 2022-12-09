using ce103_hw3__library_lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Security.Policy;
using static ce103_hw3__library_lib.SearchBook;
using System.Net;
using System.Runtime.CompilerServices;

namespace ce103_hw3_library_app
{
    public class Menu
    {
        static void Main(string[] args)
        {
           
            
            
            Directory.CreateDirectory(@"C:\LibrarySystem\Categories\");
            Directory.CreateDirectory(@"C:\LibrarySystem\Books\");
            Directory.CreateDirectory(@"C:\LibrarySystem\Book list\");
            Directory.CreateDirectory(@"C:\LibrarySystem\Book Status\Borrowed");
            Directory.CreateDirectory(@"C:\LibrarySystem\Book Status\Returned");




            string LibraryLogo = @"

  _      _____ ____  _____           _______     __   _______     _______ _______ ______ __  __ 
 | |    |_   _|  _ \|  __ \    /\   |  __ \ \   / /  / ____\ \   / / ____|__   __|  ____|  \/  |
 | |      | | | |_) | |__) |  /  \  | |__) \ \_/ /  | (___  \ \_/ | (___    | |  | |__  | \  / |
 | |      | | |  _ <|  _  /  / /\ \ |  _  / \   /    \___ \  \   / \___ \   | |  |  __| | |\/| |
 | |____ _| |_| |_) | | \ \ / ____ \| | \ \  | |     ____) |  | |  ____) |  | |  | |____| |  | |
 |______|_____|____/|_|  \_/_/    \_|_|  \_\ |_|    |_____/   |_| |_____/   |_|  |______|_|  |_|
";

            Console.WriteLine(LibraryLogo);


            string Password;

            Console.Write("Enter your password:");
            Password = Console.ReadLine();

            if (Password == "ce103")
            {
                Console.WriteLine("correct");
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Wrong password");
                do
                {
                    Console.Write("Enter your password:");
                    Password = Console.ReadLine();

                } while (Password != "ce103");
                Console.Clear();

            }


        MainMenu:
            Console.Clear();
            string Choices = @"
▓▓▓▓▓▓▓▓▓▓▓▓▓▓ Welcome to Library System ▓▓▓▓▓▓▓▓▓▓▓▓▓▓


                   1- Add Book
                   2- List Books
                   3- Search Book
                   4- Categories
                   5- Delete Book
                   6- Edit Book
                   7- Book status
                   8- Borrowers
                   9- Exit
";
            Console.WriteLine(Choices);

            Console.Write("Enter a choice:");
            Choices = Console.ReadLine();

            





            switch (Choices)
            {
                #region Add book
                // I have added the information needed to add the book
                case "1":
                    Console.Clear();
                    Console.Write("1-Book ID: ");
                    int Choices2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2-Book name: ");
                    string Choices3 = Console.ReadLine();
                    Console.Write("3-Author: ");
                    string Choices4 = Console.ReadLine();
                    Console.Write("4-Category: ");
                    string Choices5 = Console.ReadLine();
                    Console.Write("5-Year: ");
                    int Choices6 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("6-Pages: ");
                    int Choices7 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("7-Edition: ");
                    int Choices8 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("8-Editors: ");
                    string Choices9 = Console.ReadLine();
                    Console.Write("9-Publisher: ");
                    string Choices10 = Console.ReadLine();
                    Console.Write("10-Price: ");
                    double Choices11 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("11-City: ");
                    string Choices12 = Console.ReadLine();
                    Console.Write("12-Author Keywords: ");
                    string Choices13 = Console.ReadLine();
                    Console.Write("13-Tags: ");
                    string Choices14 = Console.ReadLine();
                    Console.Write("14-Abstract: ");
                    string Choices15 = Console.ReadLine();
                    Console.Write("15-URL: ");
                    string Choices16 = Console.ReadLine();
                    Console.Write("16-DOI: ");
                    int Choices17 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("17-ISBN: ");
                    int Choices18 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("18-Rack no: ");
                    int Choices19 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("19-DOI: ");
                    int Choices20 = Convert.ToInt32(Console.ReadLine());
                    
                    

                    if (File.Exists(@"C:\LibrarySystem\Books\" + Choices2 + ".dat"))
                    {
                        Console.WriteLine("Eklemek istediğin kitap zaten bulunmaktadır.");
                        
                        Console.WriteLine("Press ESC to go to main menu...");


                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                        {
                            goto MainMenu;
                        }
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Book added.");

                        Directory.CreateDirectory(@"C:\LibrarySystem\Categories\" + "\\" + Choices5 + "\\");

                        Books books = (new Books { Id = Choices2, BookName = Choices3, Author = Choices4, Category = Choices5, Year = Choices6, Pages = Choices7, Edition = Choices8, Editors = Choices9, Publisher = Choices10, Price = Choices11, City = Choices12, AuthorKeywords = Choices13, Tags = Choices14, Abstract = Choices15, URL = Choices16 });
                        StreamWriter writer = new StreamWriter(@"C:\LibrarySystem\Categories" + "\\" + Choices5 +"\\"+ Choices3 + ".dat", true, Encoding.GetEncoding("Windows-1254"));
                        writer.WriteLine("ID: " + books.Id + "\n" + "Book Name: " + books.BookName + "\n" + "Author: " + books.Author + "\n" + "Category: " + books.Category + "\n" + "Year: " + books.Year + "\n" + "Pages: " + books.Pages + "\n" + "Edition: " + books.Edition +
                            "\n" + "Editor: " + books.Editors + "\n" + "Publisher: " + books.Publisher + "\n" + "Price: " + books.Price + "\n" + "City: " + books.City + "\n" + "Author Keywords: " + books.AuthorKeywords + "\n" + "Tags: " + books.Tags + "\n" + "Abstract: " + books.Abstract + "\n" + "URL: " + books.URL + "16-DOI: " + books.DOI + "\n" + "17-ISBN: " + books.ISBN + "\n" + "18-Rack no: " + books.Rack + "\n" + "19-Row no: " + books.Row + "\n" + "\n-------------------------\n");
                        writer.Close();
                        writer.Dispose();

                        Books books1 = (new Books { Id = Choices2, BookName = Choices3, Author = Choices4, Category = Choices5, Year = Choices6, Pages = Choices7, Edition = Choices8, Editors = Choices9, Publisher = Choices10, Price = Choices11, City = Choices12, AuthorKeywords = Choices13, Tags = Choices14, Abstract = Choices15, URL = Choices16 });
                        StreamWriter writer1 = new StreamWriter(@"C:\LibrarySystem\Book list\Books.dat", true, Encoding.GetEncoding("Windows-1254"));
                        writer1.WriteLine("ID: " + books1.Id + "\n" + "Book Name: " + books1.BookName + "\n" + "Author: " + books1.Author + "\n" + "Category: " + books1.Category + "\n" + "Year: " + books1.Year + "\n" + "Pages: " + books1.Pages + "\n" + "Edition: " + books1.Edition +
                           "\n" + "Editor: " + books1.Editors + "\n" + "Publisher: " + books1.Publisher + "\n" + "Price: " + books1.Price + "\n" + "City: " + books1.City + "\n" + "Author Keywords: " + books1.AuthorKeywords + "\n" + "Tags: " + books1.Tags + "\n" + "Abstract: " + books1.Abstract + "\n" + "URL: " + books1.URL + "16-DOI: " + books.DOI + "\n" + "17-ISBN: " + books.ISBN + "\n" + "18-Rack no: " + books.Rack + "\n" + "19-Row no: " + books.Row + "\n" + "\n-------------------------\n");
                        writer1.Close();
                        writer1.Dispose();


                        StreamWriter writer2 = new StreamWriter(@"C:\LibrarySystem\Books\" + "\\" + Choices2 + ".dat", true, Encoding.GetEncoding("Windows-1254"));
                        writer2.WriteLine("ID: " + books.Id + "\n" + "Book Name: " + books.BookName + "\n" + "Author: " + books.Author + "\n" + "Category: " + books.Category + "\n" + "Year: " + books.Year + "\n" + "Pages: " + books.Pages + "\n" + "Edition: " + books.Edition +
                            "\n" + "Editor: " + books.Editors + "\n" + "Publisher: " + books.Publisher + "\n" + "Price: " + books.Price + "\n" + "City: " + books.City + "\n" + "Author Keywords: " + books.AuthorKeywords + "\n" + "Tags: " + books.Tags + "\n" + "Abstract: " + books.Abstract + "\n" + "URL: " + books.URL + "16-DOI: " + books.DOI + "\n" + "17-ISBN: " + books.ISBN + "\n" + "18-Rack no: " + books.Rack + "\n" + "19-Row no: " + books.Row + "\n" + "\n-------------------------\n");

                        writer2.Close();
                        writer2.Dispose();

                        StreamWriter writer3 = new StreamWriter(@"C:\LibrarySystem\Book Status\Returned" + "\\" + Choices2 + ".dat", true, Encoding.GetEncoding("Windows-1254"));
                        writer3.WriteLine("ID: " + books.Id + "\n" + "Book Name: " + books.BookName + "\n" + "Author: " + books.Author + "\n" + "Category: " + books.Category + "\n" + "Year: " + books.Year + "\n" + "Pages: " + books.Pages + "\n" + "Edition: " + books.Edition +
                            "\n" + "Editor: " + books.Editors + "\n" + "Publisher: " + books.Publisher + "\n" + "Price: " + books.Price + "\n" + "City: " + books.City + "\n" + "Author Keywords: " + books.AuthorKeywords + "\n" + "Tags: " + books.Tags + "\n" + "Abstract: " + books.Abstract + "\n" + "URL: " + books.URL + "16-DOI: " + books.DOI + "\n" + "17-ISBN: " + books.ISBN + "\n" + "18-Rack no: " + books.Rack + "\n" + "19-Row no: " + books.Row + "\n" + "\n-------------------------\n");

                        writer3.Close();
                        writer3.Dispose();
                        Console.WriteLine("Press ESC to go to main menu...");


                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                        {
                            goto MainMenu;
                        }
                    }


                    

                    break;
                #endregion

                #region books list
                case "2":

                    string  Text;
                    BookList list = new BookList();
                    list.bookList();
                    


                    Console.Write("Press ESC to go to main menu...");

                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        goto MainMenu;
                    }

                    break;
                #endregion

                #region serach book
                case "3":

                    Console.Clear();

                    Console.Write("Book ID: ");
                    string book_id = Console.ReadLine();
                    
                    string _location = @" C:\LibrarySystem\Books\" + book_id + ".dat";
                    
                    Console.Clear();

                    SearchBook searchBook = (new SearchBook { _file_location = _location, _book_id = book_id});


                    if (File.Exists(@" C:\LibrarySystem\Books\" + book_id + ".dat"))
                    {
                        searchBook.Searchbook();
                    }
                    else 
                    {
                        Console.WriteLine("The book you are looking for does not exist.");
                    }
                    
                    
                    
                    Console.Write("Press ESC to go to main menu...");

                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        goto MainMenu;
                    }
                    break;
                #endregion

                #region Categories
                case "4":


                CategoryMenu:
                    Console.Clear();
                    string _categorimenu = @"
▓▓▓▓▓▓▓▓▓▓▓▓▓▓ Categori Menu ▓▓▓▓▓▓▓▓▓▓▓▓▓▓

               1- Delete Category
               2- Add Category
               
";
                choice:
                    Console.WriteLine(_categorimenu);
                    Console.WriteLine("Press ESC to go to Main Menu...");
                    
                    Console.Write("Enter a choice:");
                    _categorimenu = Console.ReadLine();
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        goto MainMenu;
                    }


                    switch (_categorimenu)
                    {
                        #region case 1
                        case "1":
                            Console.Clear();
                            Console.Write("Please write the category you want to delete: ");
                            string del = Console.ReadLine();
                            

                            if (Directory.Exists(@"C:\LibrarySystem\Categories" + del))
                            {

                              
                                Console.WriteLine("The book you want to delete does not already exist");
                                Console.WriteLine("Press ESC to go to Main Menu...");
                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                {
                                    goto MainMenu;
                                }
                            }
                            else
                            {
                                Categories categories = new Categories();
                                categories.Del = del;
                                categories.category();

                                Console.Write("Category successfully deleted.\n ");
                                Console.WriteLine("Press ESC to go to Category Menu...");


                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                {
                                    goto CategoryMenu;
                                }
                                Console.ReadLine();
                            }


                            break;
                        #endregion

                        #region case 2
                        case "2":

                            Console.Write("Enter the category name: ");
                            string add = Console.ReadLine();
                            
                            
                            if (Directory.Exists(@"C:\LibrarySystem\Categories" + "\\" + add))
                            {
                                Console.WriteLine("The category you want to add already exists");
                                Console.Write("Press ESC to go to Category Menu...");

                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                {
                                    goto CategoryMenu;
                                }
                            }
                            else
                            {
                                Categories addcategory = (new Categories { AddCategory = add });
                                addcategory.addcategory();

                                Console.WriteLine("Category successfully added");
                                Console.Write("Press ESC to go to Category Menu...");

                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                {
                                    goto CategoryMenu;
                                }
                            }
                            break;
                        #endregion


                        default:
                            break;
                    }

                    break;
                #endregion

                #region Book Delete
                case "5":
                    Console.Clear();    
                    Console.Write("Enter the ID of the book you want to delete: ");
                    string dl = Console.ReadLine();

                    if (File.Exists(@"C:\LibrarySystem\Books"+"\\"+dl+".dat"))
                    {
                        BookDelete bookdelete = new BookDelete();
                        bookdelete._book_delete = dl;
                        bookdelete.bookDelete();
                        Console.WriteLine("The book has been successfully deleted.");
                        Console.WriteLine("Press ESC to go to Main Menu...");


                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                        {
                            goto MainMenu;
                        }
                    }
                    else
                    {
                        Console.WriteLine("The file you want to delete does not exist");
                        Console.WriteLine("Press ESC to go to Main Menu...");


                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                        {
                            goto MainMenu;
                        }
                    }
                    break;
                #endregion

                #region Book Edit
                case "6":





                    break;
                #endregion

                #region Book Status 
                case "7":
                  BookStatus:
                    Console.Clear();
                    string i = @"
▓▓▓▓▓▓▓▓▓▓▓▓▓▓ Book status ▓▓▓▓▓▓▓▓▓▓▓▓▓▓
 
         1- Book status Information
         2- Update Book Status
";
                    Console.WriteLine(i);
                    Console.WriteLine("Press ESC to go to Main Menu...");              
                    Console.Write("Enter a choice:");
                    i = Console.ReadLine();

                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        goto MainMenu;
                    }


                    switch (i)
                    {
                        #region information
                        case "1":
                            Console.Clear();
                            Console.Write("Book ID: ");
                            int a = Convert.ToInt32(Console.ReadLine());

                            if (File.Exists(@"C:\LibrarySystem\Book Status\Borrowed" + "\\" + a + ".dat"))
                            {
                                Console.WriteLine("The book is borrowed");
                                Console.WriteLine("Press ESC to go to book status Menu...");

                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                {
                                    goto BookStatus;
                                }
                            }
                            else if (File.Exists(@"C:\LibrarySystem\Book Status\Returned" + "\\" + a + ".dat")) 
                            {
                              Console.WriteLine("Book Available.");
                                Console.WriteLine("Press ESC to go to book status Menu...");

                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                {
                                    goto BookStatus;
                                }
                            }
                            else
                            {
                                Console.WriteLine("The book you are looking for does not exist.");

                                Console.WriteLine("Press ESC to go to book status Menu...");

                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                {
                                    goto BookStatus;
                                }
                            }
                            break;
                            #endregion 

                        #region update
                        case "2":
                            Console.Clear();
                            Console.Write("Book ID: ");
                            int x = Convert.ToInt32(Console.ReadLine());

                            BookStatus status = (new BookStatus{ _status = x });


                            if (File.Exists(@"C:\LibrarySystem\Book Status\Borrowed" + "\\" + x + ".dat"))
                            {
                                status.borrowed();
                                Console.WriteLine("successfully updated.");
                                Console.WriteLine("Press ESC to go to book status Menu...");

                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                {
                                    goto BookStatus;
                                }
                                
                            }
                            else if (File.Exists(@"C:\LibrarySystem\Book Status\Returned" + "\\" + x + ".dat"))
                            {
                                status.returned();
                                Console.WriteLine("successfully updated.");
                                Console.WriteLine("Press ESC to go to book status Menu...");

                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                {
                                    goto BookStatus;
                                }

                            }
                            else
                            {
                                Console.WriteLine("The book you are looking for is not available.");

                                Console.WriteLine("Press ESC to go to book status Menu...");

                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                {
                                    goto BookStatus;
                                }

                            }
                            break;
                            #endregion
                    }  
                    break;
                #endregion

                case "8":



                    break;
                #region Exit
                case "9":
                        Environment.Exit(0);
                    break;
                #endregion



                default:
                    Console.WriteLine("Wrong Value");
                    break;
            }
            Console.ReadLine();





        }
    }
}

