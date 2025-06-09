namespace libraryManagement;

public class LibraryItem
{
    public string Id;
    public string Title;

    public LibraryItem(string title, string id)
    {
        Title = title;
        Id = id;
    }
    public LibraryItem() { }

    public virtual void Showinfo()
    {
        Console.WriteLine("----------Library Book Details-----------");
        Console.WriteLine($"Book ID is : {Id}");
        Console.WriteLine($"Ttitle of book is : {Title}");
    }
}