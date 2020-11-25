using AuthorBLL;
using AuthorsAndBooksBLL;
using BookBLL;
using Entities;
using GenreBLL;
using ListGenreBLL;
using PublishingHouseBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AbstractBLL;

namespace WebApplication.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookLogic _bookLogic;
        private readonly IPublishingHouseLogic _publishingHouseLogic;
        private readonly IAuthorLogic _authorLogic;
        private readonly IAuthorsAndBooksLogic _authorsAndBooksLogic;
        private readonly IListGenreLogic _listGenreLogic;
        private readonly IGenreLogic _genreLogic;

        public BookController(IBookLogic bookLogic, IPublishingHouseLogic publishingHouseLogic,
            IAuthorLogic authorLogic, IAuthorsAndBooksLogic authorsAndBooksLogic, IListGenreLogic listGenreLogic,
            IGenreLogic genreLogic)
        {
            _bookLogic = bookLogic;
            _publishingHouseLogic = publishingHouseLogic;
            _authorLogic = authorLogic;
            _authorsAndBooksLogic = authorsAndBooksLogic;
            _listGenreLogic = listGenreLogic;
            _genreLogic = genreLogic;
        }

        public BookController()
        {
        }

        public ActionResult AllBooks()
        {
            List<Book> books = _bookLogic.GetAll();
            ViewData["ph"] = _publishingHouseLogic.GetAll();
            return View(books);
        }

        public ActionResult AddBook()
        {
            string title = Request.Form["title"];
            int year = Convert.ToInt32(Request.Form["year"]);
            int ph = Convert.ToInt32(Request.Form["ph"]);
            string language = Request.Form["language"];
            _bookLogic.Create(new Book(title, year, ph, language));
            return RedirectToAction("AllBooks");
        }

        public ActionResult DeleteBook(int bookId)
        {
            _bookLogic.Delete(bookId);
            return RedirectToAction("AllBooks");
        }

        public ActionResult GetBook(int bookId)
        {
            Book book = _bookLogic.GetById(bookId);
            List<AuthorsAndBooks> authorId = _authorsAndBooksLogic.GetAll().FindAll(ab => ab.BookID == bookId);
            List<Author> authors = _authorLogic.GetAll().FindAll(a => authorId.Exists(ab => ab.AuthorID == a.AuthorID));
            List<ListGenre> listGenres = _listGenreLogic.GetAll().FindAll(lg => lg.BookID == bookId);
            List<Genre> genres = _genreLogic.GetAll().FindAll(g => listGenres.Exists(lg => lg.GenreID == g.GenreID));
            ViewData["ph"] = _publishingHouseLogic.GetAll().Find(p => p.PublishingHouseID == book.PublishingHouseID)
                .PublishingHouseTitle;
            ViewData["author"] = string.Join(", ", authors.Select(a => a.AuthorFullName).ToArray());
            ViewData["genre"] = string.Join(", ", genres.Select(g => g.GenreTitle).ToArray());
            ;
            return View(book);
        }
    }
}