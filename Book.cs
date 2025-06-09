namespace libraryManagement;

public class Book : LibraryItem
{
    //public string Title { get; set; }
    public string Author { get; set; } 
    public string ISBN { get; set; } 
   // public string Id { get; set; } //International Standard Book Number
    // public Book(string title, string author, string isbn, string id)
    // {
    //     Title = title;
    //     Author = author;
    //     ISBN = isbn;
    // }

    public Book(string title, string author, string isbn, string id) : base(title, id)
    {
        Id = id;
        if (isbn.Length != 16)
        {
           throw new InvalidBookException("Lenght ISBN Number should be 16..");
        }
        ISBN = isbn;
    }
    public Book(){}
    public void Display()
    {
        Console.WriteLine("----------Book Details-----------");
        Console.WriteLine($"Title of the Book : {Title}");
        Console.WriteLine($"Author is : {Author}");
        Console.WriteLine($"ISBN : {ISBN}");
    }
}

