namespace LibraryManagementSystem.Model {
    public class LibraryItems {
        /// <summary>
        /// Getter and setter for Library Item's Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Getter and Setter for Library Item's ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Initializes the new instance of Library Item
        /// </summary>
        /// <param name="id">Id of the Library Item</param>
        /// <param name="title">Title of the Library Item</param>
        public LibraryItems(int id, string title) {
            Title = title;
            Id = id;
        }
    }
}
