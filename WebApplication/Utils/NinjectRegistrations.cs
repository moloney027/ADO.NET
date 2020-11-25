using AbstractBLL;
using AbstractDAL;
using AuthorBLL;
using AuthorDAL;
using AuthorsAndBooksBLL;
using AuthorsAndBooksDAL;
using BookBLL;
using BookCopyBLL;
using BookCopyDAL;
using BookDAL;
using BookIssuanceBLL;
using BookIssuanceDAL;
using FineBLL;
using FineDAL;
using GenreBLL;
using GenreDAL;
using ListGenreBLL;
using ListGenreDAL;
using Ninject.Modules;
using PublishingHouseBLL;
using PublishingHouseDAL;
using ReadersBLL;
using ReadersDAL;

namespace LibrarySystem2.Utils
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IBookDao>().To<BookDao>().InSingletonScope();
            Bind<IBookLogic>().To<BookLogic>().InSingletonScope();
            Bind<IBookIssuanceDao>().To<BookIssuanceDao>().InSingletonScope();
            Bind<IBookIssuanceLogic>().To<BookIssuanceLogic>().InSingletonScope();
            Bind<IPublishingHouseDao>().To<PublishingHouseDao>().InSingletonScope();
            Bind<IPublishingHouseLogic>().To<PublishingHouseLogic>().InSingletonScope();
            Bind<IReadersDao>().To<ReadersDao>().InSingletonScope();
            Bind<IReadersLogic>().To<ReadersLogic>().InSingletonScope();
            Bind<IBookCopyDao>().To<BookCopyDao>().InSingletonScope();
            Bind<IBookCopyLogic>().To<BookCopyLogic>().InSingletonScope();
            Bind<IAuthorDao>().To<AuthorDao>().InSingletonScope();
            Bind<IAuthorLogic>().To<AuthorLogic>().InSingletonScope();
            Bind<IAuthorsAndBooksDao>().To<AuthorsAndBooksDao>().InSingletonScope();
            Bind<IAuthorsAndBooksLogic>().To<AuthorsAndBooksLogic>().InSingletonScope();
            Bind<IListGenreDao>().To<ListGenreDao>().InSingletonScope();
            Bind<IListGenreLogic>().To<ListGenreLogic>().InSingletonScope();
            Bind<IGenreDao>().To<GenreDao>().InSingletonScope();
            Bind<IGenreLogic>().To<GenreLogic>().InSingletonScope();
            Bind<IFineDao>().To<FineDao>().InSingletonScope();
            Bind<IFineLogic>().To<FineLogic>().InSingletonScope();
        }
    }
}