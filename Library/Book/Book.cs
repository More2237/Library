namespace Library.Book;

public class Book
{
    public Guid Id { get;set; }

    public string Title { get;set; }

    public string Author { get;set; }
    public string Genre { get;set; }

    public int Year { get;set; }
    public bool IsAvailable { get;set; }

    public Book()
    {
        Id = Guid.NewGuid();
        Title = string.Empty;
        Author = string.Empty;
        Genre = string.Empty;
        Year = 0;
        IsAvailable = false;
        
    }
    
    

}