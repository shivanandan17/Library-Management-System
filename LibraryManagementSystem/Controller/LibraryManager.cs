using LibraryManagementSystem.Model;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.View;

namespace LibraryManagementSystem.Controller {
    internal class LibraryManager {
        public void HandleMainMenu() {
            while (true) {
                Console.Clear();
                DisplayMainMenu();
                int choice = InputManager.GetMenuChoice(3);
                switch (choice) {
                    case 1:
                        AddNewBook();
                        break;
                    case 2:
                        ViewBooks();
                        break;
                    case 3:
                        return;
                }
            }
        }

        private void ViewBooks() {
            Console.Clear();
            List<Book> books = LibraryDatabase.GetAllBooks();
            Console.WriteLine("===== Existing Books =====\n");
            if (books.Count == 0) {
                Console.WriteLine("[Error] Book list is empty.");
            } else {
                foreach (Book book in books) {
                    Console.WriteLine("Book Id: " + book.Id);
                    Console.WriteLine("Book Title: " + book.Title);
                    Console.WriteLine("Book Author: " + book.Author);
                    Console.WriteLine("------------------------------\n");
                }
            }
            Console.WriteLine("Please press a key to continue...");
            Console.ReadKey();
        }

        private void AddNewBook() {
            Console.Clear();
            Console.WriteLine("===== Add new book =====\n");
            int id = InputManager.GetLibraryItemId();
            string title = InputManager.GetStringValue("Book Title");
            string author = InputManager.GetStringValue("Book Author");
            LibraryDatabase.AddBook(new Book(id, title, author));
            Console.WriteLine("[Success] Book added successfully.\n");
            Console.WriteLine("Please press a key to continue...");
            Console.ReadKey();
        }

        private void DisplayMainMenu() {
            Console.WriteLine("===== Main Menu =====\n");
            Console.WriteLine("1. Add Books");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Exit");
        }
    }
}
