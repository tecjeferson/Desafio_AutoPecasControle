using lojaDePecasDeCarro.Data;
using lojaDePecasDeCarro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lojaDePecasDeCarro.Controllers
{
    public class PecasController : Controller
    {
        public PecasController()
        {
            
        }

        // GET: Pecas
        public ActionResult Index(PecasBO model)
        {

            PecasBO db = new PecasBO();
            var ListItem = db.GetPecas().ToList();

            return View(ListItem);
            
            
        }

        // GET: Pecas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pecas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pecas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pecas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pecas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pecas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pecas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
