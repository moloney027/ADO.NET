namespace Entities
{
    public class Fine
    {
        public Fine(){}

        public Fine(int idFine, int idBI, int amountFine)
        {
            FineID = idFine;
            BookIssuanceID = idBI;
            FineAmount = amountFine;
        }

        public int FineID { get; set; }
        public int BookIssuanceID { get; set; }
        public int FineAmount { get; set; }
    }
}