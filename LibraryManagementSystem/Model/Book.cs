namespace LibraryManagementSystem.Model {
    public class Book: LibraryItems {
        public string Author { get; set; }

        public Book(int id, string title, string author) : base (id, title) {
            Author = author;
        }
    }
}
