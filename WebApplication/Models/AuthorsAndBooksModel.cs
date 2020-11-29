namespace WebApplication.Models
{
    public class AuthorsAndBooksModel
    {
        public int IDAuthorsAndBooks { get; set; }
        public int AuthorID { get; set; }
        public int BookID { get; set; }

        public AuthorsAndBooksModel(int idAuthorsAndBooks, int authorId, int bookId)
        {
            IDAuthorsAndBooks = idAuthorsAndBooks;
            AuthorID = authorId;
            BookID = bookId;
        }
    }
}