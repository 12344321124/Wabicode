using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonsBarberStudio.Models;

namespace MonsBarberStudio.Controllers
{
    public class DisponibilidadBarberoController : Controller
    {
        public static List<DisponibilidadBarbero> lista = new List<DisponibilidadBarbero>();
        // GET: DisponibilidadBarberoController
        public ActionResult Index()
        {
            return View(lista);
        }

        // GET: DisponibilidadBarberoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DisponibilidadBarberoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DisponibilidadBarberoController/Create
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

        // GET: DisponibilidadBarberoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DisponibilidadBarberoController/Edit/5
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

        // GET: DisponibilidadBarberoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DisponibilidadBarberoController/Delete/5
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
