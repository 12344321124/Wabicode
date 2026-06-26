using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonsBarberStudio.Models;

namespace MonsBarberStudio.Controllers
{
    public class EstadoCitaController : Controller
    {
        public static List<EstadoCita> lista = new List<EstadoCita>();
        // GET: EstadoCitaController
        public ActionResult Index()
        {
            return View(lista);
        }

        // GET: EstadoCitaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EstadoCitaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadoCitaController/Create
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

        // GET: EstadoCitaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EstadoCitaController/Edit/5
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

        // GET: EstadoCitaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EstadoCitaController/Delete/5
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
