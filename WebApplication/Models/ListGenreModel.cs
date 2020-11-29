namespace WebApplication.Models
{
    public class ListGenreModel
    {
        public int IDListGenre { get; set; }
        public int BookID { get; set; }
        public int GenreID { get; set; }

        public ListGenreModel(int idListGenre, int bookId, int genreId)
        {
            IDListGenre = idListGenre;
            BookID = bookId;
            GenreID = genreId;
        }
    }
}