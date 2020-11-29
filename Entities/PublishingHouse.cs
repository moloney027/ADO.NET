namespace Entities
{
    public class PublishingHouse
    {
        public PublishingHouse(){}

        public PublishingHouse(int idPH, string titePH, int datePH)
        {
            PublishingHouseID = idPH;
            PublishingHouseTitle = titePH;
            DateOfEstablishment = datePH;
        }

        public PublishingHouse(string publishingHouseTitle, int dateOfEstablishment)
        {
            PublishingHouseTitle = publishingHouseTitle;
            DateOfEstablishment = dateOfEstablishment;
        }

        public int PublishingHouseID { get; set; }
        public string PublishingHouseTitle { get; set; }
        public int DateOfEstablishment { get; set; }
    }
}