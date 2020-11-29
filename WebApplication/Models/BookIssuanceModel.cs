using System;

namespace WebApplication.Models
{
    public class BookIssuanceModel
    {
        public int BookIssuanceID { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DateOfCompletion { get; set; }
        public int LibraryCard { get; set; }
        public int BookCopyID { get; set; }

        public BookIssuanceModel(int bookIssuanceId, DateTime dateOfIssue, DateTime dateOfCompletion, int libraryCard, int bookCopyId)
        {
            BookIssuanceID = bookIssuanceId;
            DateOfIssue = dateOfIssue;
            DateOfCompletion = dateOfCompletion;
            LibraryCard = libraryCard;
            BookCopyID = bookCopyId;
        }
    }
}