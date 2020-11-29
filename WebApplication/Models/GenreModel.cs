namespace WebApplication.Models
{
    public class GenreModel
    {
        public int GenreID { get; set; }
        public string GenreTitle { get; set; }

        public GenreModel(int genreId, string genreTitle)
        {
            GenreID = genreId;
            GenreTitle = genreTitle;
        }
    }
}