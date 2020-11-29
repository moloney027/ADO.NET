using Entities;
using FineBLL;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AbstractBLL;
using AutoMapper;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class FineController : Controller
    {
        private readonly IFineLogic _fineLogic;
        
        private readonly IMapper _mapper;

        public FineController()
        {
        }

        public FineController(IFineLogic fineLogic, IMapper mapper)
        {
            _fineLogic = fineLogic;
            _mapper = mapper;  
        }

        public ActionResult GetFine(int bookIssuanceId)
        {
            TempData["BookIssuanceId"] = bookIssuanceId;
            List<Fine> fineList = _fineLogic.GetAll().FindAll(f => f.BookIssuanceID == bookIssuanceId);
            return View(_mapper.Map<List<FineModel>>(fineList));
        }

        public ActionResult AddFine(int amount, string article)
        {
            _ = _fineLogic.Create(new Fine( (int)TempData.Peek("BookIssuanceID"), (int)amount));
            return RedirectToAction("GetFine", new { bookIssuanceId = TempData.Peek("BookIssuanceID") });
        }

        public ActionResult DeleteFine(int id)
        {
            _fineLogic.Delete(id);
            return RedirectToAction("GetFine", new { bookIssuanceId = TempData["BookIssuanceID"] });
        }
    }
}