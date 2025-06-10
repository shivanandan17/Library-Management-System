using LibraryManagementSystem.Model;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.View;

namespace LibraryManagementSystem.Controller {
    internal class LibraryManager {
        public void HandleMainMenu() {
            List<MenuHandler> mainMenuAction = new List<MenuHandler>() {
                new MenuHandler("Add New Book", AddNewBook ),
                new MenuHandler("View Books", ViewBooks),
                new MenuHandler("Exit", () => { })
            };

            HandleMenuActions("Main Menu", mainMenuAction);
        }

        public void HandleMenuActions(string menuTitle, List<MenuHandler> menuActions) {
            while (true) {
                Console.Clear();
                Console.WriteLine($"===== {menuTitle} =====\n");
                OutputManager.DisplayMenuTitles(menuActions);

                Console.Write("\n[Menu] Enter your choice: ");
                string userInput = Console.ReadLine();
                bool isInteger = int.TryParse(userInput, out int choice);

                if (!isInteger) {
                    Console.WriteLine("[Error] Invalid Input!");
                }
                else if (choice < 1 || choice > menuActions.Count) {
                    Console.WriteLine($"[Error] Choice should be between 1 to {menuActions.Count}");
                } else if (choice == menuActions.Count) {
                    return;
                }
                else {
                    menuActions[choice - 1].Function.Invoke();
                }
                Console.WriteLine("\nPlease press a key to continue...");
                Console.ReadKey();
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
        }

        private void AddNewBook() {
            Console.Clear();
            Console.WriteLine("===== Add new book =====\n");
            int id = InputManager.GetLibraryItemId();
            string title = InputManager.GetStringValue("Book Title");
            string author = InputManager.GetStringValue("Book Author");
            LibraryDatabase.AddBook(new Book(id, title, author));
            Console.WriteLine("[Success] Book added successfully.\n");
        }
    }
}
