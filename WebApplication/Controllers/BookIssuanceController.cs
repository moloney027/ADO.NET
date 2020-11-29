using BookBLL;
using BookCopyBLL;
using BookIssuanceBLL;
using Entities;
using ReadersBLL;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AbstractBLL;
using AutoMapper;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class BookIssuanceController : Controller
    {
        private readonly IBookIssuanceLogic _issuanceLogic;
        private readonly IBookLogic _bookLogic;
        private readonly IReadersLogic _readersLogic;
        private readonly IBookCopyLogic _bookCopyLogic;
        
        private readonly IMapper _mapper;

        public BookIssuanceController(IBookLogic bookLogic, IBookIssuanceLogic bookIssuanceLogic,
            IReadersLogic readersLogic, IBookCopyLogic bookCopyLogic, IMapper mapper)
        {
            _bookLogic = bookLogic;
            _issuanceLogic = bookIssuanceLogic;
            _readersLogic = readersLogic;
            _bookCopyLogic = bookCopyLogic;
            _mapper = mapper;
        }

        public BookIssuanceController()
        {
        }

        public ActionResult ReaderBookIssuance(int libraryCard)
        {
            TempData["FullName"] = _readersLogic.GetById(libraryCard).ReaderFullName;
            TempData["LibraryCard"] = libraryCard;
            List<BookCopyTitleModel> bookCopyModels = new List<BookCopyTitleModel>();
            List<BookCopy> bookCopies = _bookCopyLogic.GetAll();
            List<Book> books = _bookLogic.GetAll();
            foreach (BookCopy bc in bookCopies)
            {
                Book book = books.Find(b => b.BookID == bc.BookID);
                bookCopyModels.Add(new BookCopyTitleModel(bc.BookCopyID, book.BookID, book.BookTitle));
            }

            TempData["BookCopy"] = bookCopyModels;

            TempData["BookIssuance"] = _mapper.Map<List<BookIssuanceModel>>(_issuanceLogic.GetAll().FindAll(bi => bi.LibraryCard == libraryCard));
            return RedirectToAction("GetBookIssuance");
        }

        public ActionResult AddBookIssuance(DateTime dateOfIssue, DateTime dateOfCompletion, int bookCopyId)
        {
            Console.WriteLine(_issuanceLogic.Create(new BookIssuance(dateOfIssue, dateOfCompletion,
                (int) TempData.Peek("LibraryCard"), bookCopyId)));
            return RedirectToAction("ReaderBookIssuance", new {libraryCard = (int) TempData["LibraryCard"]});
        }

        public ActionResult DeleteBookIssuance(int libraryCard, int id)
        {
            Console.WriteLine(_issuanceLogic.Delete(id));
            return RedirectToAction("ReaderBookIssuance", new {libraryCard});
        }

        // public ActionResult FindReader(int bookIssuanceId)
        // {
        //     
        // }

        public ActionResult GetBookIssuance()
        {
            return View(TempData["BookIssuance"]);
        }
    }
}