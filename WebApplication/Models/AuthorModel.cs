using System;

namespace WebApplication.Models
{
    public class AuthorModel
    {
        public int AuthorID { get; set; }
        public string AuthorFullName { get; set; }
        public DateTime AuthorDateOfBirth { get; set; }
        public string AuthorPlaceOfBirth { get; set; }

        public AuthorModel(int authorId, string authorFullName, DateTime authorDateOfBirth, string authorPlaceOfBirth)
        {
            AuthorID = authorId;
            AuthorFullName = authorFullName;
            AuthorDateOfBirth = authorDateOfBirth;
            AuthorPlaceOfBirth = authorPlaceOfBirth;
        }
    }
}