using _26AprelTaskHome.Datacontext;
using _26AprelTaskHome.Models;

internal class Program
{
    static Taskcontexs _dbContext = new Taskcontexs();
    private static void Main(string[] args)
    {
        // Remove(1);

        List<Book> books = AllBook();
        foreach (Book book in books)
        {
            Console.WriteLine(book.Name);
        }
        //  AddBoook("seir", "bextiyar vehabzade");

    }
    public static void AddBoook(string name,string authorname)
    {
        Book book = new Book()
        {
            Name = name,
            AuthorName = authorname
        };
        _dbContext.Books.Add(book);
        _dbContext.SaveChanges();

    }
    public static List<Book> AllBook()
    {
        List<Book> books = _dbContext.Books.ToList();
        return books;    
    }
    public static void Remove(int id)
    {
        Book book = _dbContext.Books.Find(id);
       
        _dbContext.Books.Remove(book);

        _dbContext.SaveChanges();
    }
}