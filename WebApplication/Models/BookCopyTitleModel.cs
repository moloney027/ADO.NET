namespace WebApplication.Models
{
    public class BookCopyTitleModel
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string BookTitle { get; set; }

        public BookCopyTitleModel(int id, int bookId, string bookTitle)
        {
            Id = id;
            BookId = bookId;
            BookTitle = bookTitle;
        }
    }
}