using libraryManagement;
public class DVD : LibraryItem
{
    public int Dvd_Number { get; set; }
    public DVD(string title, string id, int dvdnumber) : base(title,id)
    {
        Title = title;
        Id = id;
        Dvd_Number = dvdnumber;
    }
    public override void Showinfo()
    {
        Console.WriteLine("-------------DVD Details-------------");
        Console.WriteLine($"DVD ID is : {Id}");
        Console.WriteLine($"Ttitle of DVD is : {Title}");
        Console.WriteLine($"DVD Number of DVD is : {Dvd_Number}");
    }
}