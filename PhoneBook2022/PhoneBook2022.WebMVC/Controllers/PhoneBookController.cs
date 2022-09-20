using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Domain;
using PhoneBook2022.WebMVC.Models;

namespace PhoneBook2022.WebMVC.Controllers
{
    public class PhoneBookController : Controller
    {
        // GET: PhoneBookController
        public ActionResult Index()
        {
            // Dit iedere keer herhalen is niet heel erg netjes. In PROG6 leer je hier coole nieuwe
            // features voor. Die mag je natuurlijk al wel gebruiken... kijk eens naar de 
            // structuur van de LLTravel website.
            var bla = new TelephoneBook();
            var result = new PhoneBookModel();
            result.AddRange(bla.AllOrderByLastName().Select(x => new PersonModel(x)));
            return View("List",result);
        }

        // GET: PhoneBookController/Details/5
        public ActionResult Details(int id)
        {
            return View(new PersonModel(new TelephoneBook().GetById(id)));
        }

        // GET: PhoneBookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhoneBookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PhoneBookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PhoneBookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PhoneBookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PhoneBookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
