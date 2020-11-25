using ReadersBLL;
using System.Web.Mvc;
using AbstractBLL;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IReadersLogic _readersLogic;

        public HomeController(IReadersLogic readersLogic)
        {
            _readersLogic = readersLogic;
        }

        public HomeController()
        {
        }

        public ActionResult Index()
        {
            TempData["login"] = null;
            return View();
        }

        [HttpPost]
        public ActionResult Authorization(string login)
        {
            TempData["login"] = login;
            System.Collections.Generic.List<Entities.Readers> readers = _readersLogic.GetAll();
            if (readers.Exists(r => r.LibraryCardReader.Equals(int.Parse(login))))
            {
                return RedirectToAction("ReaderBookIssuance", "BookIssuance", new { libraryCard = login });
            }

            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult AdminAuthorization(string password)
        {
            if (password != "admin") return RedirectToAction("Index");
            TempData["login"] = "admin";
            return RedirectToAction("AllReaders", "Reader");

        }
    }
}