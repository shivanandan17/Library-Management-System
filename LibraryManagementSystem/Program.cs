using LibraryManagementSystem.Controller;

namespace LibraryManagementSystem {
    internal class Program {
        public static void Main() {
            LibraryManager libraryManager = new LibraryManager();
            libraryManager.HandleMainMenu();
        }
    }
}
