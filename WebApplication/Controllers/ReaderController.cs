using System.Collections.Generic;
using System.Web.Mvc;
using AbstractBLL;
using AutoMapper;
using Entities;
using ReadersBLL;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ReaderController : Controller
    {
        private readonly IReadersLogic _readersLogic;
        
        private readonly IMapper _mapper;

        public ReaderController(IReadersLogic readersLogic, IMapper mapper)
        {
            _readersLogic = readersLogic;
            _mapper = mapper;  
        }

        public ReaderController()
        {
        }

        public ActionResult AllReaders()
        {
            var readers = _readersLogic.GetAll();
            return View(_mapper.Map<List<ReadersModel>>(readers));
        }

        public ActionResult GetReader(int libraryCard)
        {
            var reader = _readersLogic.GetById(libraryCard);
            return View (_mapper.Map<ReadersModel>(reader));
        }

        public ActionResult DeleteReader(int libraryCard)
        {
            _readersLogic.Delete(libraryCard);
            return RedirectToAction("AllReaders");
        }

        public ActionResult AddReader(string fullName, int age, string address)
        {
            _readersLogic.Create(new Readers(fullName, age, address));
            return RedirectToAction("AllReaders");
        }
    }
}