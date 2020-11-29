namespace WebApplication.Models
{
    public class PublishingHouseModel
    {
        public int PublishingHouseID { get; set; }
        public string PublishingHouseTitle { get; set; }
        public int DateOfEstablishment { get; set; }

        public PublishingHouseModel(int publishingHouseId, string publishingHouseTitle, int dateOfEstablishment)
        {
            PublishingHouseID = publishingHouseId;
            PublishingHouseTitle = publishingHouseTitle;
            DateOfEstablishment = dateOfEstablishment;
        }
    }
}