namespace WebApplication.Models
{
    public class BookCopyModel
    {
        public int BookCopyID { get; set; }
        public int BookID { get; set; }

        public BookCopyModel(int bookCopyId, int bookId)
        {
            BookCopyID = bookCopyId;
            BookID = bookId;
        }
    }
}