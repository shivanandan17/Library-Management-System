namespace libraryManagement;
public class Magazine : LibraryItem
{
    public int IssueNumber{ get; set; }
    public Magazine(string title, string id, int issueNumber) : base(title, id)
    {
        Id = id;
        IssueNumber = issueNumber;
    }
    public override void Showinfo()
    {
        Console.WriteLine("-------------Magazine Details-------------");
        Console.WriteLine($"Magazine ID is : {Id}");
        Console.WriteLine($"Ttitle of Magazine is : {Title}");
        Console.WriteLine($"Issue Number of Magazine is : {IssueNumber}");
    }
}