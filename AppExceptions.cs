namespace libraryManagement;

class InvalidBookException : Exception
{
    public InvalidBookException(string message) : base(message)
    {
        
    }
}