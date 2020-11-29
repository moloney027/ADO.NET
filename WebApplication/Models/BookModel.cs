namespace WebApplication.Models
{
    public class BookModel
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public int YearOfWriting { get; set; }
        public int PublishingHouseID { get; set; }
        public string LanguageBook { get; set; }

        public BookModel(int bookId, string bookTitle, int yearOfWriting, int publishingHouseId, string languageBook)
        {
            BookID = bookId;
            BookTitle = bookTitle;
            YearOfWriting = yearOfWriting;
            PublishingHouseID = publishingHouseId;
            LanguageBook = languageBook;
        }
    }
}