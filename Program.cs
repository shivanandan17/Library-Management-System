
using libraryManagement;

// //Book book1 = new Book { Title = "Mahabarat", Author = "ABC" , ISBN = "ISBN000167"};
try
{
    Book b2 = new Book { Title = "Mahabarat", Author = "ABC", ISBN = "IS7", Id = "1444" };//("Raamayan", "EFG", "ISBN004368",  "003" );
    //b2.Showinfo();
    Book b3 = new Book("IEEE", "PQRST", "87", "23212");
    Magazine m1 = new Magazine("Peace", "111", 68);
    m1.Showinfo();
    DVD d1 = new DVD("Silent", "TS", 143);
    d1.Showinfo();

}
catch (InvalidBookException ex)
{
    Console.WriteLine($"Error Message : {ex.Message}");
}

Console.WriteLine("------------Pay Due Amount for extra days----------");
Console.WriteLine("Number of days : ");
int days = int.Parse(Console.ReadLine());
var due = 15;
int diff = 0;
var fine = 0;
if (days > due)
{
    diff = days - due;
    fine = diff * 2;
}
Console.WriteLine($"The Fine amount you have to pay  : {fine}");
Console.WriteLine("Do you have membership?..");
bool isMembership = bool.Parse(Console.ReadLine());
double final_fine_amount = 0;
if (isMembership)
{
    final_fine_amount = fine - (fine * 0.1);
}
Console.WriteLine($"If you have membership this is your fine amount : {final_fine_amount}");
Console.WriteLine("Press any key to exit..");
Console.ReadKey();