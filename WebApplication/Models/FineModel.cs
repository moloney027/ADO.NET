namespace WebApplication.Models
{
    public class FineModel
    {
        public int FineID { get; set; }
        public int BookIssuanceID { get; set; }
        public int FineAmount { get; set; }

        public FineModel(int fineId, int bookIssuanceId, int fineAmount)
        {
            FineID = fineId;
            BookIssuanceID = bookIssuanceId;
            FineAmount = fineAmount;
        }
    }
}