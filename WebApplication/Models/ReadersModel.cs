namespace WebApplication.Models
{
    public class ReadersModel
    {
        public int LibraryCardReader { get; set; }
        public string ReaderFullName { get; set; }
        public int ReaderAge { get; set; }
        public string ReaderAddress { get; set; }

        public ReadersModel(int libraryCardReader, string readerFullName, int readerAge, string readerAddress)
        {
            LibraryCardReader = libraryCardReader;
            ReaderFullName = readerFullName;
            ReaderAge = readerAge;
            ReaderAddress = readerAddress;
        }
    }
}