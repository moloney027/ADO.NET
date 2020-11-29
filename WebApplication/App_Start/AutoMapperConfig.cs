using AutoMapper;
using Entities;
using WebApplication.Models;

namespace LibrarySystem2
{
    public class AutoMapperConfig
    {
        public class AdaptationsToAdaptationsModel : Profile
        {
            public AdaptationsToAdaptationsModel()
            {
                CreateMap<Adaptations, AdaptationsModel>()
                    .ForMember(dest => dest.AdaptationID, opt => opt.MapFrom(src => src.AdaptationID))
                    .ForMember(dest => dest.BookID, opt => opt.MapFrom(src => src.BookID))
                    .ForMember(dest => dest.AdaptationYear, opt => opt.MapFrom(src => src.AdaptationYear))
                    .ForMember(dest => dest.AdaptationType, opt => opt.MapFrom(src => src.AdaptationType))
                    .ForMember(dest => dest.AdaptationCountry, opt => opt.MapFrom(src => src.AdaptationCountry));
            }
        }
        public class AdaptationsModelToAdaptations : Profile
        {
            public AdaptationsModelToAdaptations()
            {
                CreateMap<AdaptationsModel, Adaptations>()
                    .ForMember(dest => dest.AdaptationID, opt => opt.MapFrom(src => src.AdaptationID))
                    .ForMember(dest => dest.BookID, opt => opt.MapFrom(src => src.BookID))
                    .ForMember(dest => dest.AdaptationYear, opt => opt.MapFrom(src => src.AdaptationYear))
                    .ForMember(dest => dest.AdaptationType, opt => opt.MapFrom(src => src.AdaptationType))
                    .ForMember(dest => dest.AdaptationCountry, opt => opt.MapFrom(src => src.AdaptationCountry));
            }
        }


        public class AuthorToAuthorModel : Profile
        {
            public AuthorToAuthorModel()
            {
                CreateMap<Author, AuthorModel>()
                    .ForMember(dest => dest.AuthorID, opt => opt.MapFrom(src => src.AuthorID))
                    .ForMember(dest => dest.AuthorFullName, opt => opt.MapFrom(src => src.AuthorFullName))
                    .ForMember(dest => dest.AuthorDateOfBirth, opt => opt.MapFrom(src => src.AuthorDateOfBirth))
                    .ForMember(dest => dest.AuthorPlaceOfBirth, opt => opt.MapFrom(src => src.AuthorPlaceOfBirth));
            }
        }
        public class AuthorModelToAuthor : Profile
        {
            public AuthorModelToAuthor()
            {
                CreateMap<AuthorModel, Author>()
                    .ForMember(dest => dest.AuthorID, opt => opt.MapFrom(src => src.AuthorID))
                    .ForMember(dest => dest.AuthorFullName, opt => opt.MapFrom(src => src.AuthorFullName))
                    .ForMember(dest => dest.AuthorDateOfBirth, opt => opt.MapFrom(src => src.AuthorDateOfBirth))
                    .ForMember(dest => dest.AuthorPlaceOfBirth, opt => opt.MapFrom(src => src.AuthorPlaceOfBirth));
            }
        }


        public class AabToAabModel : Profile
        {
            public AabToAabModel()
            {
                CreateMap<AuthorsAndBooks, AuthorsAndBooksModel>()
                    .ForMember(dest => dest.IDAuthorsAndBooks, opt => opt.MapFrom(src => src.IDAuthorsAndBooks))
                    .ForMember(dest => dest.AuthorID, opt => opt.MapFrom(src => src.AuthorID))
                    .ForMember(dest => dest.BookID, opt => opt.MapFrom(src => src.BookID));
            }
        }
        public class AabModelToAab : Profile
        {
            public AabModelToAab()
            {
                CreateMap<AuthorsAndBooksModel, AuthorsAndBooks>()
                    .ForMember(dest => dest.IDAuthorsAndBooks, opt => opt.MapFrom(src => src.IDAuthorsAndBooks))
                    .ForMember(dest => dest.AuthorID, opt => opt.MapFrom(src => src.AuthorID))
                    .ForMember(dest => dest.BookID, opt => opt.MapFrom(src => src.BookID));
            }
        }


        public class BookCopyToBookCopyModel : Profile
        {
            public BookCopyToBookCopyModel()
            {
                CreateMap<BookCopy, BookCopyModel>()
                    .ForMember(copy => copy.BookCopyID, opt => opt.MapFrom(src => src.BookCopyID))
                    .ForMember(copy => copy.BookID, opt => opt.MapFrom(src => src.BookID));
            }
        }
        public class BookCopyModelToBookCopy : Profile
        {
            public BookCopyModelToBookCopy()
            {
                CreateMap<BookCopyModel, BookCopy>()
                    .ForMember(copy => copy.BookCopyID, opt => opt.MapFrom(src => src.BookCopyID))
                    .ForMember(copy => copy.BookID, opt => opt.MapFrom(src => src.BookID));
            }
        }
        
        
        public class BookIssuanceToBookIssuanceModel : Profile
        {
            public BookIssuanceToBookIssuanceModel()
            {
                CreateMap<BookIssuance, BookIssuanceModel>()
                    .ForMember(dest => dest.BookIssuanceID, opt => opt.MapFrom(src => src.BookIssuanceID))
                    .ForMember(dest => dest.BookCopyID, opt => opt.MapFrom(src => src.BookCopyID))
                    .ForMember(dest => dest.DateOfIssue, opt => opt.MapFrom(src => src.DateOfIssue))
                    .ForMember(dest => dest.LibraryCard, opt => opt.MapFrom(src => src.LibraryCard))
                    .ForMember(dest => dest.DateOfCompletion, opt => opt.MapFrom(src => src.DateOfCompletion));
            }
        }
        public class BookIssuanceModelToBookIssuance : Profile
        {
            public BookIssuanceModelToBookIssuance()
            {
                CreateMap<BookIssuanceModel, BookIssuance>()
                    .ForMember(dest => dest.BookIssuanceID, opt => opt.MapFrom(src => src.BookIssuanceID))
                    .ForMember(dest => dest.BookCopyID, opt => opt.MapFrom(src => src.BookCopyID))
                    .ForMember(dest => dest.DateOfIssue, opt => opt.MapFrom(src => src.DateOfIssue))
                    .ForMember(dest => dest.LibraryCard, opt => opt.MapFrom(src => src.LibraryCard))
                    .ForMember(dest => dest.DateOfCompletion, opt => opt.MapFrom(src => src.DateOfCompletion));
            }
        }
        
        
        public class BookToBookModel : Profile
        {
            public BookToBookModel()
            {
                CreateMap<Book, BookModel>()
                    .ForMember(dest => dest.BookID, opt => opt.MapFrom(src => src.BookID))
                    .ForMember(dest => dest.BookTitle, opt => opt.MapFrom(src => src.BookTitle))
                    .ForMember(dest => dest.LanguageBook, opt => opt.MapFrom(src => src.LanguageBook))
                    .ForMember(dest => dest.YearOfWriting, opt => opt.MapFrom(src => src.YearOfWriting))
                    .ForMember(dest => dest.PublishingHouseID, opt => opt.MapFrom(src => src.PublishingHouseID));
            }
        }
        public class BookModelToBook : Profile
        {
            public BookModelToBook()
            {
                CreateMap<BookModel, Book>()
                    .ForMember(dest => dest.BookID, opt => opt.MapFrom(src => src.BookID))
                    .ForMember(dest => dest.BookTitle, opt => opt.MapFrom(src => src.BookTitle))
                    .ForMember(dest => dest.LanguageBook, opt => opt.MapFrom(src => src.LanguageBook))
                    .ForMember(dest => dest.YearOfWriting, opt => opt.MapFrom(src => src.YearOfWriting))
                    .ForMember(dest => dest.PublishingHouseID, opt => opt.MapFrom(src => src.PublishingHouseID));
            }
        }
        
        
        public class FineToFineModel : Profile
        {
            public FineToFineModel()
            {
                CreateMap<Fine, FineModel>()
                    .ForMember(dest => dest.FineID, opt => opt.MapFrom(src => src.FineID))
                    .ForMember(dest => dest.FineAmount, opt => opt.MapFrom(src => src.FineAmount))
                    .ForMember(dest => dest.BookIssuanceID, opt => opt.MapFrom(src => src.BookIssuanceID));
            }
        }
        public class FineModelToFine : Profile
        {
            public FineModelToFine()
            {
                CreateMap<Fine, FineModel>()
                    .ForMember(dest => dest.FineID, opt => opt.MapFrom(src => src.FineID))
                    .ForMember(dest => dest.FineAmount, opt => opt.MapFrom(src => src.FineAmount))
                    .ForMember(dest => dest.BookIssuanceID, opt => opt.MapFrom(src => src.BookIssuanceID));
            }
        }
        
        
        public class GenreToGenreModel : Profile
        {
            public GenreToGenreModel()
            {
                CreateMap<Genre, GenreModel>()
                    .ForMember(dest => dest.GenreID, opt => opt.MapFrom(src => src.GenreID))
                    .ForMember(dest => dest.GenreTitle, opt => opt.MapFrom(src => src.GenreTitle));
            }
        }
        public class GenreModelToGenre : Profile
        {
            public GenreModelToGenre()
            {
                CreateMap<GenreModel, Genre>()
                    .ForMember(dest => dest.GenreID, opt => opt.MapFrom(src => src.GenreID))
                    .ForMember(dest => dest.GenreTitle, opt => opt.MapFrom(src => src.GenreTitle));
            }
        }
        
        
        public class ListGenreToListGenreModel : Profile
        {
            public ListGenreToListGenreModel()
            {
                CreateMap<ListGenre, ListGenreModel>()
                    .ForMember(dest => dest.IDListGenre, opt => opt.MapFrom(src => src.IDListGenre))
                    .ForMember(dest => dest.GenreID, opt => opt.MapFrom(src => src.GenreID))
                    .ForMember(dest => dest.BookID, opt => opt.MapFrom(src => src.BookID));
            }
        }
        public class ListGenreModelToListGenre : Profile
        {
            public ListGenreModelToListGenre()
            {
                CreateMap<ListGenreModel, ListGenre>()
                    .ForMember(dest => dest.IDListGenre, opt => opt.MapFrom(src => src.IDListGenre))
                    .ForMember(dest => dest.GenreID, opt => opt.MapFrom(src => src.GenreID))
                    .ForMember(dest => dest.BookID, opt => opt.MapFrom(src => src.BookID));
            }
        }
        
        
        public class PublishingHouseToPublishingHouseModel : Profile
        {
            public PublishingHouseToPublishingHouseModel()
            {
                CreateMap<PublishingHouse, PublishingHouseModel>()
                    .ForMember(dest => dest.PublishingHouseID, opt => opt.MapFrom(src => src.PublishingHouseID))
                    .ForMember(dest => dest.PublishingHouseTitle, opt => opt.MapFrom(src => src.PublishingHouseTitle))
                    .ForMember(dest => dest.DateOfEstablishment, opt => opt.MapFrom(src => src.DateOfEstablishment));
            }
        }
        public class PublishingHouseModelToPublishingHouse : Profile
        {
            public PublishingHouseModelToPublishingHouse()
            {
                CreateMap<PublishingHouseModel, PublishingHouse>()
                    .ForMember(dest => dest.PublishingHouseID, opt => opt.MapFrom(src => src.PublishingHouseID))
                    .ForMember(dest => dest.PublishingHouseTitle, opt => opt.MapFrom(src => src.PublishingHouseTitle))
                    .ForMember(dest => dest.DateOfEstablishment, opt => opt.MapFrom(src => src.DateOfEstablishment));
            }
        }
        
        
        public class ReadersToReadersModel : Profile
        {
            public ReadersToReadersModel()
            {
                CreateMap<Readers, ReadersModel>()
                    .ForMember(dest => dest.LibraryCardReader, opt => opt.MapFrom(src => src.LibraryCardReader))
                    .ForMember(dest => dest.ReaderAge, opt => opt.MapFrom(src => src.ReaderAge))
                    .ForMember(dest => dest.ReaderFullName, opt => opt.MapFrom(src => src.ReaderFullName))
                    .ForMember(dest => dest.ReaderAddress, opt => opt.MapFrom(src => src.ReaderAddress));
            }
        }
        public class ReadersModelToReaders : Profile
        {
            public ReadersModelToReaders()
            {
                CreateMap<ReadersModel, Readers>()
                    .ForMember(dest => dest.LibraryCardReader, opt => opt.MapFrom(src => src.LibraryCardReader))
                    .ForMember(dest => dest.ReaderAge, opt => opt.MapFrom(src => src.ReaderAge))
                    .ForMember(dest => dest.ReaderFullName, opt => opt.MapFrom(src => src.ReaderFullName))
                    .ForMember(dest => dest.ReaderAddress, opt => opt.MapFrom(src => src.ReaderAddress));
            }
        }
    }
}