using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonsBarberStudio.Models;

namespace MonsBarberStudio.Controllers
{
    public class CategoriaProductoController : Controller
    {
        public static List<CategoriaProducto> lista = new List<CategoriaProducto>();
        // GET: CategoriaProductoController
        public ActionResult Index()
        {
            return View(lista);
        }

        // GET: CategoriaProductoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriaProductoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaProductoController/Create
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

        // GET: CategoriaProductoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriaProductoController/Edit/5
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

        // GET: CategoriaProductoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriaProductoController/Delete/5
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
