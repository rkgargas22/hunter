using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tmf.Hunter.Api.Controllers
{
    public class CutomerVerificationController : Controller
    {
        // GET: CutomerVerificationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CutomerVerificationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CutomerVerificationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CutomerVerificationController/Create
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

        // GET: CutomerVerificationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CutomerVerificationController/Edit/5
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

        // GET: CutomerVerificationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CutomerVerificationController/Delete/5
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
