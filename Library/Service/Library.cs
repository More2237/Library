namespace Library.Service;

public class Library
{
    List<Book.Book> books = new List<Book.Book>();

        public void addBook()
        {
            Book.Book newBook = new Book.Book();
            newBook.Id = Guid.NewGuid();

            Console.Write("Title: ");
            newBook.Title = Console.ReadLine();
            if (newBook.Title == String.Empty)
            {
                Console.Write("The title is invalid: ");
            }
            else
            {
                Console.Write("Author: ");
                newBook.Author = Console.ReadLine();
                if (newBook.Author == String.Empty)
                {
                    Console.WriteLine("The author is invalid: ");
                }
                else
                {
                    Console.Write("Genre: ");
                    newBook.Genre = Console.ReadLine();
                    if (newBook.Genre == String.Empty)
                    {
                        Console.WriteLine("The genre is invalid: ");
                    }
                    else
                    {
                        Console.Write("Year: ");
                        newBook.Year = Convert.ToInt32(Console.ReadLine());
                        if (newBook.Year < 2015)
                        {
                            Console.WriteLine("The year is invalid: ");

                        }
                        else if (newBook.Year > 2025)
                        {
                            Console.WriteLine("The year is invalid: ");

                        }





                        books.Add(newBook);
                        Console.WriteLine("The book added successfully");
                    }

                }
            }



        }

        public  void AllBooks()
        {
            if (books.Count > 0)
            {
                foreach (var book in books)
                {
                    Console.WriteLine(
                        $"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Year: {book.Year}");
                }

            }
            else
            {
                Console.WriteLine("No books found.");
            }
        }

        public void SearchBooks()
        {
            Book.Book searchBook = new Book.Book();
            Console.WriteLine("Enter search term: Title,Author,Genre,Year ");
            string search = Console.ReadLine();
            if (search == books.FirstOrDefault().Title || search == books.FirstOrDefault().Author ||
                search == books.FirstOrDefault().Genre)
            {
                Console.WriteLine("Books found \n" + searchBook);
            }
        }

    }

