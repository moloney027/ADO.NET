namespace WebApplication.Models
{
    public class AdaptationsModel
    {
        public int AdaptationID { get; set; }
        public int BookID { get; set; }
        public string AdaptationType { get; set; }
        public int AdaptationYear { get; set; }
        public string AdaptationCountry { get; set; }

        public AdaptationsModel(int adaptationId, int bookId, string adaptationType, int adaptationYear, string adaptationCountry)
        {
            AdaptationID = adaptationId;
            BookID = bookId;
            AdaptationType = adaptationType;
            AdaptationYear = adaptationYear;
            AdaptationCountry = adaptationCountry;
        }
    }
}