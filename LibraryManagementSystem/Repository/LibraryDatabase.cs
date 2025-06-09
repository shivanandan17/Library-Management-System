using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.Repository {
    public static class LibraryDatabase {
        static List<Book> _booksList = new List<Book>();

        public static void AddBook(Book newBook) {
            _booksList.Add(newBook);
        }

        public static List<Book> GetAllBooks() {
            return _booksList;
        }
    }
}
