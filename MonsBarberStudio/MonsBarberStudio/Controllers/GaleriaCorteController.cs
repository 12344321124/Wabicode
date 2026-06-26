using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonsBarberStudio.Models;

namespace MonsBarberStudio.Controllers
{
    public class GaleriaCorteController : Controller
    {
        public static List<GaleriaCorte> lista = new List<GaleriaCorte>();
        // GET: GaleriaCorteController
        public ActionResult Index()
        {
            return View(lista);
        }

        // GET: GaleriaCorteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GaleriaCorteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GaleriaCorteController/Create
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

        // GET: GaleriaCorteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GaleriaCorteController/Edit/5
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

        // GET: GaleriaCorteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GaleriaCorteController/Delete/5
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
