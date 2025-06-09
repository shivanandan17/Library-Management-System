using LibraryManagementSystem.Model;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.View {
    public class InputManager {
        public static int GetMenuChoice(int maximumChoice) {
            while (true) {
                Console.Write("\n[Menu] Enter your choice: ");
                string userInput = Console.ReadLine();
                bool isInteger = int.TryParse(userInput, out int choice);

                if (!isInteger) {
                    Console.WriteLine("[Error]: Invalid Input!");
                }
                else if (choice < 0 || choice > maximumChoice) {
                    Console.WriteLine($"[Error] Is should be between 1 and {maximumChoice}");
                }
                else {
                    return choice;
                }
            }
        }

        public static int GetLibraryItemId() {
            while (true) {
                Console.Write("Enter Id: ");
                string userInput = Console.ReadLine();
                bool isInteger = int.TryParse(userInput, out int itemId);

                if (!isInteger) {
                    Console.WriteLine("[Error] Invalid Input!");
                } else if (IsIdAlreadyExist(itemId)) {
                    Console.WriteLine("[Error] Id already exist");
                } else {
                    return itemId;
                }
            }
        }

        public static string GetStringValue(string consoleMessage) {
            while(true) {
                Console.Write($"Enter {consoleMessage}: ");
                string userInput = Console.ReadLine();
                if (String.IsNullOrEmpty(userInput)) {
                    Console.WriteLine($"[Error] {consoleMessage} should no be empty");
                } else {
                    return userInput;
                }
            }
        }

        private static bool IsIdAlreadyExist(int id) {
            List<Book> existingBookList = LibraryDatabase.GetAllBooks();
            foreach (Book book in existingBookList) {
                if (book.Id == id)
                    return true;
            }
            return false;
        }
    }
}
